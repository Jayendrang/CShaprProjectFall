INSERT INTO D*/SCOUNT(DISCOUNT_ID,DISCOUNT_RATE,CREATED_BY,CREATED_DATE,MODIFY_BY,MODIFY_DATE) VALUES ('DIS4','3','ADMIN','07/01/2017','ADMIN','07/01/2017');
SELECT * FROM DISCOUNT;
INSERT INTO dbo.VENDOR(VENDOR_NAME,VENDOR_ID,VENDOR_ADDRESS,VENDOR_CONTACT,VENDOR_EMAIL_ID,VENDOR_STATUS,VENDOR_DISCOUNT_ID,VENDOR_BALANCE_AMOUNT,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE) 
VALUES('WALMART','VEN1120','KC 78776','4565123356','WMRT21W@WALMART.COM','ACTIVE','DIS4','1340.02','MANAGER02','09/11/2000','MANAGER02','09/11/2000');
SELECT * FROM VENDOR;
INSERT INTO USER_TABLE(NAME,CONTACT,ADDRESS,EMAIL_ID,USER_ID,PASSWORD,ROLE,IS_VENDOR,VENDOR_ID,VENDOR_NAME,STATUS,CREATED_BY,CREATED_DATE,MODIFIED_BY,MODIFIED_DATE) 
VALUES ('JAYENDRAN',4795442053,'WARRENS','JAYE@GMAIL.COM','JaY2234','Hello','MANAGER','YES','VEN1120','WALMART','ACTIVE','ADMIN22','09/11/2000','ADMIN22','09/11/2000');
SELECT * FROM USER_TABLE;
use COSIGNMENT_DATABASE;
/*RETRIEVING PRODUCTS FOR ORDER FORM*/

SELECT PRODUCT.PRODUCT_ID,PRODUCT.PRODUCT_TYPE,MANUFACTURER.MANUFACTURER_NAME FROM PRODUCT INNER JOIN MANUFACTURER ON PRODUCT.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID ORDER BY MANUFACTURER.MANUFACTURER_ID;

/*RETRIEVEING PRODUCTS FOR ORDER FORM */
SELECT PRODUCT.PRODUCT_ID,PRODUCT_TYPE,PRODUCT.PRODUCT_NAME,PRODUCT.PRODUCT_CURRENT_COUNT,
PRODUCT.PRICE_PER_UNIT,PRODUCT.MINIMUM_COUNT,MANUFACTURER.MANUFACTURER_ID, MANUFACTURER.MANUFACTURER_NAME,MANUFACTURER_DETAIL FROM PRODUCT INNER JOIN MANUFACTURER ON PRODUCT.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID WHERE MANUFACTURER.MANUFACTURER_ID='MAN002' ORDER BY MANUFACTURER.MANUFACTURER_NAME;

 /* RETRIEVING VENDOR SPECIFIC ORDERS*/
 INSERT INTO MANUFACTURER VALUES('MAN004','MSI','GAMING PC,GAMING LAPTOP AND SERVER SUPPLIER','JaY2234','11/12/2016','JaY2234','11/12/2016');
 SELECT * FROM MANUFACTURER;

 SELECT * FROM PRODUCT;
 DELETE  PRODUCT WHERE PRODUCT_NAME='MICROSOFT';
 
 SELECT distinct PRODUCT_TYPE FROM PRODUCT;
 
 UPDATE PRODUCT SET PRODUCT_CURRENT_COUNT=PRODUCT_CURRENT_COUNT-10 WHERE PRODUCT_ID='PRD001';

 INSERT INTO PRODUCT VALUES('PRD022','STANDARD MULTIMEDIA KEYBOARD','KEYBOARD','MAN002','1000','100','19.00','11/11/2015','JaY2234','JaY2234','11/11/2015');
 
 INSERT INTO PRODUCT VALUES('PRD023','POLTTER MOUSE','MOUSE','MAN001','1000','100','19.00','11/11/2015','JaY2234','JaY2234','11/11/2015');
 
 
 INSERT INTO PRODUCT VALUES('PRD024','MSI GT1070','GRAPHICS CARD 4G','MAN004','1000','100','399.00','11/11/2015','JaY2234','JaY2234','11/11/2015');

 SELECT PRODUCT.PRODUCT_ID,PRODUCT_TYPE,PRODUCT.PRODUCT_NAME,PRODUCT.MINIMUM_COUNT,PRODUCT.PRODUCT_CURRENT_COUNT,PRODUCT.PRICE_PER_UNIT,MANUFACTURER.MANUFACTURER_ID, MANUFACTURER.MANUFACTURER_NAME,MANUFACTURER_DETAIL FROM PRODUCT INNER JOIN MANUFACTURER ON PRODUCT.MANUFACTURER_ID = MANUFACTURER.MANUFACTURER_ID ORDER BY MANUFACTURER.MANUFACTURER_NAME;