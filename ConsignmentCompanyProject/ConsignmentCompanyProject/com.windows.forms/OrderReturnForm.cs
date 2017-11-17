using ConsignmentCompanyProject.com.app.business;
using ConsignmentCompanyProject.com.app.dataobjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ConsignmentCompanyProject.windows.forms
{
    public partial class OrderReturnForm : Form
    {
        

        int _gridNumber = 0;
        private OrderReturnHandler orderReturnHandler;
        private OrderReturnProperties orderReturnProperty = new OrderReturnProperties();
        private List<OrderProperties> orderItineraryList = new List<OrderProperties>();

        public OrderReturnForm( )
        {
            InitializeComponent();
           
            orderReturnHandler = new OrderReturnHandler();
        }
        

        private void OrderReturnForm_Load(object sender, EventArgs e)
        {
            //DataGrid Headers
            dataGridViewProcessedOrders.ColumnCount = 5;
            dataGridViewProcessedOrders.Columns[0].Name = "#";
            dataGridViewProcessedOrders.Columns[0].ReadOnly = true;
            dataGridViewProcessedOrders.Columns[1].Name = "DATE";
            dataGridViewProcessedOrders.Columns[1].ReadOnly = true;
            dataGridViewProcessedOrders.Columns[2].Name = "ORDER ID";
            dataGridViewProcessedOrders.Columns[2].ReadOnly = true;
            dataGridViewProcessedOrders.Columns[3].Name = "BALANCE AMOUNT";
            dataGridViewProcessedOrders.Columns[3].ReadOnly = true;
            dataGridViewProcessedOrders.Columns[4].Name = "TOTAL AMOUNT";
            dataGridViewProcessedOrders.Columns[4].ReadOnly = true;


            //dataGrid view Itinerary Headers
            dataGridViewItinerary.ColumnCount = 6;
            dataGridViewItinerary.Columns[0].Name = "#";
            dataGridViewItinerary.Columns[0].ReadOnly = true;
            dataGridViewItinerary.Columns[1].Name = "PRODUCT ID";
            dataGridViewItinerary.Columns[1].ReadOnly = true;
            dataGridViewItinerary.Columns[2].Name = "PRODUCT TYPE";
            dataGridViewItinerary.Columns[2].ReadOnly = true;
            dataGridViewItinerary.Columns[3].Name = "PRODUCT NAME";
            dataGridViewItinerary.Columns[3].ReadOnly = true;
            dataGridViewItinerary.Columns[4].Name = "PRODUCT COUNT";
            dataGridViewItinerary.Columns[4].ReadOnly = true;
            dataGridViewItinerary.Columns[5].Name = "PRICE PER UNIT";
            dataGridViewItinerary.Columns[5].ReadOnly = true;
            

            textBoxReturnId.Text = orderReturnHandler.generateOrderReturnNumber();
            //**********TEST
            orderReturnHandler.getCustomerData(null);
            fillProcessedOrderDataGrid(orderReturnHandler.getGridData());

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateReturn_Click(object sender, EventArgs e)
        {
            if ((orderReturnProperty.Return_Description != null) && (orderReturnProperty.Return_Description.Trim().Length>0 ))
            {
                MessageBox.Show("PLEASE PROVIDE RETURN REASON", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                orderReturnProperty.Return_Description = textBoxReturnReason.Text;
                orderReturnProperty.Count = Convert.ToInt16(textBoxCount.Text);
            }
           bool result= orderReturnHandler.submitOrderReturn(orderReturnProperty);
            if (result)
            {
                MessageBox.Show("RETURN ORDER PLACED SUCCESSFULLY","RETURN ORDER",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void dataGridViewProcessedOrder_CellClick(object sender, DataGridViewCellEventArgs args)
        {
            try
            {
                string CellOrderId = dataGridViewProcessedOrders.Rows[args.RowIndex].Cells[2].Value.ToString();
                if (CellOrderId.Contains("ORD"))
                {
                    fillItineraryDataGrid(CellOrderId);
                   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void dataGridViewItinerary_CellClick(object sender, DataGridViewCellEventArgs args)
        {
            try {
                Console.WriteLine("{0}", args.GetType().Name);               
            string CellProductId = dataGridViewItinerary.Rows[args.RowIndex].Cells[1].Value.ToString();
                if (CellProductId.Contains("PRD"))
                {
                   orderReturnProperty = getItineraryValues(CellProductId);
                    Console.WriteLine("Cell clicked");
                }
            }catch(Exception ex) { Console.WriteLine(ex.StackTrace); }

        }

        private void fillItineraryDataGrid(string orderID)
        {
            orderItineraryList = orderReturnHandler.getOrderItinerary(orderID);
            string[] gridViewRow;
            int index = 0;
            dataGridViewItinerary.Rows.Clear();

             foreach (com.app.dataobjects.OrderProperties orderItinerary in orderItineraryList)
            {
                ++index;
                textBoxOrderId.Text = orderItinerary.Order_Id;
                textBoxVendorName.Text = orderItinerary.Vendor_Id;
                gridViewRow = new string[] { index.ToString(), orderItinerary.Product_Id, orderItinerary.Product_Type, orderItinerary.Product_Name, orderItinerary.Count.ToString(), orderItinerary.Price_Per_Unit.ToString("c") };
                dataGridViewItinerary.Rows.Add(gridViewRow);
                
            }
            dataGridViewItinerary.CellClick += new DataGridViewCellEventHandler(this.dataGridViewItinerary_CellClick);

        }
        private void fillProcessedOrderDataGrid(List<OrderGridFields> gridData)
        {
            string[] dataGridRows;
            foreach (OrderGridFields rowData in gridData)
            {
                ++_gridNumber;
                dataGridRows = new string[] { _gridNumber.ToString(), rowData.date, rowData.orderId, rowData.balance, rowData.total };
                dataGridViewProcessedOrders.Rows.Add(dataGridRows);
            }
            dataGridViewProcessedOrders.CellClick += new DataGridViewCellEventHandler(this.dataGridViewProcessedOrder_CellClick);

        }


        private OrderReturnProperties getItineraryValues(string productId)
        {
            List<OrderProperties> itinerary = orderItineraryList;
            OrderReturnProperties returnOrderProperty = new com.app.dataobjects.OrderReturnProperties();
            foreach (com.app.dataobjects.OrderProperties itineraryDetails in itinerary)
            {
                if (itineraryDetails.Product_Id.Equals(productId))
                {
                    returnOrderProperty.Order_Id = itineraryDetails.Order_Id;
                    returnOrderProperty.Return_Order_Id = textBoxReturnId.Text;
                    returnOrderProperty.Vendor_Id = itineraryDetails.Vendor_Id;
                    //************test
                    returnOrderProperty.User_Id = "Jay11144205";
                    returnOrderProperty.Product_Id = itineraryDetails.Product_Id;
                    returnOrderProperty.Product_Type = itineraryDetails.Product_Type;
                    returnOrderProperty.Product_Name = itineraryDetails.Product_Name;
                    returnOrderProperty.Count = itineraryDetails.Count;
                    returnOrderProperty.Price_Per_Unit = itineraryDetails.Price_Per_Unit;
                    if ((textBoxReturnReason != null) && (textBoxReturnReason.Text.Length>0))
                    {
                        returnOrderProperty.Return_Description = textBoxReturnReason.Text;
                    }
                    returnOrderProperty.Return_Status = "NEW RETURN";
                    //***********test
                    returnOrderProperty.Created_By = "Jay11144205";

                }
            }
            return returnOrderProperty;
        }

        private void textBoxCount_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBoxCount_Validating(object sender, CancelEventArgs e)
        {
            try { 
            int returnCount = Convert.ToInt16(textBoxCount.Text);
            if( returnCount <= orderReturnProperty.Count)
            {
                double total = returnCount * (orderReturnProperty.Price_Per_Unit);
                textBoxReturnTotal.Text = total.ToString("c");

            }
            else
            {
                MessageBox.Show("The count should be less than or equal to Itinerary count");

            }
            }catch(Exception ex) { Console.WriteLine("", ex.StackTrace); }
        }
    }
}
