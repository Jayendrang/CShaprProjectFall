using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsignmentCompanyProject.com.app.dataobjects;
namespace ConsignmentCompanyProject.com.app.model
{

    /*
     * Created by Jayendran Gurumoorthy
     *  */
    class DiscountDBProcessHandler
    {
        //Add new discount information in discount table
        public bool addNewDiscountRate(DiscountProperties discountInfo, string UserInfo)
        {
            bool result = false;
            if (discountInfo != null) { 
            string insertQueryString = "INSERT INTO DISCOUNT(DISCOUNT_ID,DISCOUNT_RATE,CREATED_BY,CREATED_DATE,MODIFY_BY,MODIFY_DATE) VALUES (@DISCOUNT_ID,@DISCOUNT_RATE,@CREATED_BY,@CREATED_DATE,@MODIFY_BY,@MODIFY_DATE)";
            List<KeyValuePair<string, string>> tableParameter = new List<KeyValuePair<string, string>>();
                tableParameter.Add(new KeyValuePair<string, string>("@DISCOUNT_ID",discountInfo.Discount_Id));
                tableParameter.Add(new KeyValuePair<string, string>("@DISCOUNT_RATE", discountInfo.Discount_Rate));
                tableParameter.Add(new KeyValuePair<string, string>("@CREATED_BY", UserInfo));
                tableParameter.Add(new KeyValuePair<string, string>("@CREATED_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
                tableParameter.Add(new KeyValuePair<string, string>("@MODIFY_BY", UserInfo));
                tableParameter.Add(new KeyValuePair<string, string>("@MODIFY_DATE", com.app.utlitiy.BusinessUtlities.getCurrentDateTime));
                result=DatabaseConnectionHandler.executeInsertDbQuery(insertQueryString, tableParameter);
            }
            return result;
        }

        //Retrieve all the discount information from discount table
        public List<DiscountProperties> getDiscountList()
        {
            System.Data.DataSet dataset = new System.Data.DataSet();
            List<DiscountProperties> discountList = new List<DiscountProperties>();
            string selectQueryString = "SELECT DISCOUNT_ID,DISCOUNT_RATE,CREATED_BY,CREATED_DATE,MODIFY_BY,MODIFY_DATE FROM DISOCUNT";
            dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, null);

            if (dataset != null)
            {
                foreach(System.Data.DataRow row in dataset.Tables[0].Rows)
                {
                    DiscountProperties discountData = new DiscountProperties();
                    discountData.Discount_Id = row["Discount_Id"].ToString();
                    discountData.Discount_Rate = row["Discount_rate"].ToString();
                    discountData.audit_Information.createdBy = row["Created_by"].ToString();
                    discountData.audit_Information.createdOn = row["Created_date"].ToString();
                    discountData.audit_Information.modifiedBy = row["Modify_by"].ToString();
                    discountData.audit_Information.modifiedOn = row["Modify_date"].ToString();
                    discountList.Add(discountData);

                }
            }

            return discountList;
        }

        public bool removeDiscountData(string discountId)
        {
            bool result=false;
            if (discountId != null) { 
            string deleteQueryString = "DELETE FROM DISCOUNT WHERE DISCOUNT_ID=@DISCOUNT_ID";

            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("@DISCOUNT_ID", discountId));

                result = DatabaseConnectionHandler.executeDeleteQuery(deleteQueryString, parameters);
            }
            return result;
        }
        public static DiscountProperties getDiscountOfCustomer(string vendor_Discount_Id)
        {
            System.Data.DataSet dataset = new System.Data.DataSet();
            DiscountProperties discount = new DiscountProperties();
            string selectQueryString = "SELECT DISCOUNT_RATE,DISCOUNT_ID FROM DISCOUNT WHERE DISCOUNT_ID=@DISCOUNT_ID;";
            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("@DISCOUNT_ID",vendor_Discount_Id));

            dataset = DatabaseConnectionHandler.executeSelectQuery(selectQueryString, parameters);
            if (dataset != null)
            {
                foreach(System.Data.DataRow row in dataset.Tables[0].Rows)
                {
                    discount.Discount_Id = row["Discount_Id"].ToString();
                    discount.Discount_Rate = row["Discount_Rate"].ToString();
                }
            }
            return discount;
        }
    }
}
