' eShopCONNECT for Connected Business
' Module: Const.vb
'
' This software is the copyright of Connected Business and
' may not be copied, duplicated or modified other than as permitted
' in the licence agreement.  This software has been generated using 
' the Connected Business SDK and may incorporate certain intellectual 
' property of Interprise Solutions Inc. who's
' rights are hereby recognised.
'

'-------------------------------------------------------------------
'
' Last Updated - 02 April 2014

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'   Description -    This module 
'
' Amendment Log
'------------------------------------------------------------------------------------------
' Date     | Name            | Vers.     | Description
'------------------------------------------------------------------------------------------
' 03/09/08 | TJS             | 2008.0.01 | Original 
' 24/01/09 | TJS             | 2009.1.00 | Added missing SourceMerchantID definitions
' 02/02/09 | TJS             | 2009.1.04 | Added AT_CREDIT_CARD_TYPE, AT_PAYMENT_TYPE_CODE
'                                        | and AT_ACTION_COMPLETE
' 06/02/09 | TJS             | 2009.1.05 | Added AT_XML_TO_SEND, AT_SALES_ORDER_CODE, AT_IS_VOIDED, 
'                                        | AT_SHIPPING_METHOD and AT_SHIPPING_METHOD_GROUP
' 11/02/09 | TJS             | 2009.1.07 | added GENERIC_XML_ORDER_INVOICE_ITEM_NAME, AT_ITEM_NAME
'                                        | AT_WEBSITE_CODE, AT_SOURCE_CUSTOMER_ID, AT_TYPE
'                                        | adn GENERIC_XML_STATUS_SOURCE_MERCHANT_ID
' 20/02/09 | TJS             | 2009.1.08 | Added new values for Amazon 
' 09/03/09 | TJS             | 2009.1.09 | Added Amazon Status update paths and corrected AMAZON_ORDER_ITEM_FEE_DETAILS
' 14/03/09 | TJS             | 2009.1.10 | Added GENERIC_XML_ORDER_INVOICE_ITEM_DROP_SHIP and 
'                                        | GENERIC_XML_ORDER_INVOICE_ITEM_DROP_SHIP_REF
' 03/04/09 | TJS             | 2009.2.00 | Added definitions for Custom DB Fields
' 25/04/09 | TJs             | 2009.2.03 | Added AT_CURRENCY_CODE
' 11/05/09 | TJS             | 2009.2.06 | Added AT_IS_VOIDED
' 23/05/09 | TJS             | 2009.2.08 | Modified AMAZON_ROOT_CATEGORY and added AMAZON_SEARCH_TERM_TAG_LOCATION
' 08/06/09 | TJS             | 2009.2.10 | Added GENERIC_XML_ORDER_PRICES_INCLUDE_TAX, GENERIC_XML_INVOICE_PRICES_INCLUDE_TAX,
'                                        | GENERIC_XML_CREDITNOTE_PRICES_INCLUDE_TAX, GENERIC_XML_ORDER_DISCOUNT_COUPON_DESCRIPTION
'                                        | and GENERIC_XML_ORDER_DISCOUNT_COUPON_VALUE
' 18/06/09 | TJS             | 2009.2.14 | Added AT_ATTRIBUTE_CODE
' 13/07/09 | TJS             | 2009.3.00 | Added Volusion constants and Credit Card Transaction Status plus 
'                                        | Lead, Prospect and Customer import types
' 24/07/09 | TJS             | 2009.3.03 | Corrected Prospect and Customer address XML paths
' 26/08/09 | TJS             | 2009.3.05 | added AT_SOURCE_INVOICE_CODE
' 06/10/09 | TJS             | 2009.3.07 | Added AMAZON_CORE_TAG_LOCATION, AMAZON_VARIATION_TAG_LOCATION
'                                        | AMAZON_CLASSIFICATION_DATA_TAG_LOCATION, AMAZON_PRODUCT_DATA_TAG_LOCATION
'                                        | AMAZON_REPORT_ERROR_LIST and GENERIC_XML_REPROCESS
' 15/12/09 | TJS             | 2009.3.09 | Added AMAZON_REPORT_SUMMARY and Channel Advisor constants
' 18/12/09 | TJS             | 2009.3.12 | added CHANNEL_ADV_ORDER_STATUS
' 31/12/09 | TJS             | 2010.0.00 | Added constants for quote import and for Channel Advisor direct Soap connection
' 19/08/10 | TJS             | 2010.1.00 | Added new Stored Procedure Parameters
' 22/09/10 | TJS             | 2010.1.01 | Added AT_SOURCE_PAYMENT_TYPE and CHANNEL_ADV_ORDER_PAYMENT_DETAILS
' 27/09/10 | TJS             | 2010.1.02 | Added ChannelAdvCarrier
' 18/03/11 | TJs             | 2011.0.01 | Added AT_LICENCE_CODE, AT_SITE_ID, AT_INSTANCE_ID, AT_MANUFACTURER_CODE and AT_ADDITIONAL_FILTER
' 05/04/11 | TJS             | 2011.0.08 | Removed AT constants duplicated in Imports Interprise.Framework.Inventory.Shared.Const 
' 09/07/11 | TJS/FA          | 2011.1.00 | Added UpdateCustomer variable to quotes, invoices and orders
' 26/10/11 | TJS             | 2011.1.xx | Modified to pass source tax code etc in XML for tax inclusive proces
' 02/12/11 | TJS             | 2011.2.00 | Added eBay and modified to cater for multiple payments plus enabling connectors to have different tax settings for each connection
' 16/01/12 | TJS             | 2010.2.02 | Added Sears.com connector settings
' 10/06/12 | TJS             | 2012.1.05 | Added GENERIC_XML_ORDER_INVOICE_ITEM_SOURCE_COMMISSION and GENERIC_XML_ORDER_INVOICE_ITEM_SOURCE_FULFILLMENT
' 05/07/12 | TJS             | 2012.1.08 | Added Amazon FBA connector settings
' 02/08/12 | TJS             | 2012.1.11 | Added GENERIC_XML_INVOICE_POST_INVOICE
' 13/11/13 | TJS             | 2013.3.08 | Added AT_ATTRIBUTE_USAGE and AT_ATTRIBUTE_ALT_USAGE
' 20/11/13 | TJS             | 2013.4.00 | Added 3DCart connector settings
' 02/04/14 | TJS             | 2014.0.01 | Added Inventory Item Bundle constants and corrected Channel Advisor CHANNEL_ADV_STATUS_SET_ORDER_EXPORT_STATUS
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Namespace [Shared]
    Public Module [Const]
        ' Generic XML file XML paths
        Public Const GENERIC_XML_SOURCE_CODE As String = "eShopCONNECT/Source/SourceCode"
        Public Const GENERIC_XML_SOURCE_NAME As String = "eShopCONNECT/Source/SourceName"
        Public Const GENERIC_XML_REPROCESS As String = "eShopCONNECT/Source/Reprocess" ' TJS 06/10/09
        Public Const GENERIC_XML_SOURCE_AUTHENTICATION As String = "eShopCONNECT/Source/Authentication"
        Public Const GENERIC_XML_SOURCE_IMPORT_TYPE As String = "eShopCONNECT/ImportType"

        ' start of code added TJS 31/12/09
        ' Generic XML Quote Paths
        Public Const GENERIC_XML_QUOTE_LIST As String = "eShopCONNECT/Quote"
        Public Const GENERIC_XML_QUOTE_COUNT As String = "eShopCONNECT/QuoteCount"
        Public Const GENERIC_XML_QUOTE_CUSTOMER_ORDER_REF As String = "Quote/CustomerOrderRef"
        Public Const GENERIC_XML_QUOTE_SOURCE_QUOTE_REF As String = "Quote/SourceQuoteRef"
        Public Const GENERIC_XML_QUOTE_SOURCE_WEBSITE_REF As String = "Quote/SourceWebSiteRef"
        Public Const GENERIC_XML_QUOTE_SOURCE_MERCHANT_ID As String = "Quote/SourceMerchantID"
        Public Const GENERIC_XML_QUOTE_PRICES_INCLUDE_TAX As String = "Quote/PricesIncludeTax"
        Public Const GENERIC_XML_QUOTE_TAXCODE_FOR_SOURCE_TAX As String = "Quote/TaxCodeForSourceTax" ' TJS 26/10/11
        Public Const GENERIC_XML_QUOTE_DATE As String = "Quote/QuoteDate"
        Public Const GENERIC_XML_QUOTE_CURRENCY As String = "Quote/QuoteCurrency"
        Public Const GENERIC_XML_QUOTE_CUSTOMER_SALES_COUPON As String = "Quote/CustomerSalesCoupon"
        Public Const GENERIC_XML_QUOTE_CUSTOMER_SALES_REP_GROUP_CODE As String = "Quote/SalesRepGroupCode" ' RCD 2019/08/12
        Public Const GENERIC_XML_QUOTE_CUSTOMER_SALES_REP_CODE As String = "Quote/SalesRepCode" ' RCD 2019/08/15
        Public Const GENERIC_XML_QUOTE_CUSTOMER_NOTES As String = "Quote/Notes" ' RCD 2019/08/13
        Public Const GENERIC_XML_QUOTE_CUSTOMER_SALES_AGENCY As String = "Quote/SalesAgency" ' RCD 2019/08/13
        Public Const GENERIC_XML_QUOTE_CUSTOMER_ORDER_TAKER As String = "Quote/OrderTaker" ' RCD 2019/08/13
        Public Const GENERIC_XML_QUOTE_CUSTOMER_BUYER_NAME As String = "Quote/BuyerName" ' RCD 2019/08/13
        Public Const GENERIC_XML_QUOTE_CUSTOMER_BUYER_PHONE As String = "Quote/BuyerPhone" ' RCD 2019/08/13
        Public Const GENERIC_XML_QUOTE_CUSTOMER_BUYER_EMAIL As String = "Quote/BuyerEmail" ' RCD 2019/08/13
        Public Const GENERIC_XML_QUOTE_CUSTOMER_CREDIT_CARD_TOKEN As String = "Quote/CreditCardToken" ' RCD 2019/08/13
        Public Const GENERIC_XML_QUOTE_UPDATE_CUSTOMER As String = "Quote/UpdateCustomer" ' TJS/FA 09/07/11
        Public Const GENERIC_XML_QUOTE_DISCOUNT_COUPON_DESCRIPTION As String = "Quote/DiscountCoupon/DiscountDescription"
        Public Const GENERIC_XML_QUOTE_DISCOUNT_COUPON_VALUE As String = "Quote/DiscountCoupon/DiscountValue"
        Public Const GENERIC_XML_QUOTE_CUSTOM_FIELDS As String = "Quote/CustomField"
        Public Const GENERIC_XML_QUOTE_BILLING_DETAILS As String = "Quote/BillingDetails"
        Public Const GENERIC_XML_QUOTE_BILLING_DETAILS_CUSTOMER As String = GENERIC_XML_QUOTE_BILLING_DETAILS & "/Customer"
        Public Const GENERIC_XML_QUOTE_BILLING_DETAILS_ADDRESS As String = GENERIC_XML_QUOTE_BILLING_DETAILS & "/BillingAddress"
        Public Const GENERIC_XML_QUOTE_SHIPPING_DETAILS As String = "Quote/ShippingDetails"
        Public Const GENERIC_XML_QUOTE_SHIPPING_DETAILS_CUSTOMER As String = GENERIC_XML_QUOTE_SHIPPING_DETAILS & "/Customer"
        Public Const GENERIC_XML_QUOTE_SHIPPING_DETAILS_ADDRESS As String = GENERIC_XML_QUOTE_SHIPPING_DETAILS & "/ShippingAddress"
        Public Const GENERIC_XML_QUOTE_SHIPPING_DETAILS_METHOD As String = GENERIC_XML_QUOTE_SHIPPING_DETAILS & "/ShippingMethod"
        Public Const GENERIC_XML_QUOTE_SHIPPING_DETAILS_METHOD_GROUP As String = GENERIC_XML_QUOTE_SHIPPING_DETAILS & "/ShippingMethodGroup"
        Public Const GENERIC_XML_QUOTE_SHIPPING_DETAILS_SHIPPING_DATE As String = GENERIC_XML_QUOTE_SHIPPING_DETAILS & "/ShippingDate"
        Public Const GENERIC_XML_QUOTE_SHIPPING_DETAILS_LATEST_SHIPPING_DATE As String = GENERIC_XML_QUOTE_SHIPPING_DETAILS & "/LatestShippingDate"
        Public Const GENERIC_XML_QUOTE_TOTALS As String = "Quote/QuoteTotals"
        Public Const GENERIC_XML_QUOTE_ITEM_LIST As String = "Quote/Item"
        Public Const GENERIC_XML_QUOTE_CUSTOMER_COMMENTS As String = "Quote/CustomerComments"
        ' end of code added TJS 31/12/09

        ' Generic XML Order Paths
        Public Const GENERIC_XML_ORDER_LIST As String = "eShopCONNECT/Order"
        Public Const GENERIC_XML_ORDER_COUNT As String = "eShopCONNECT/OrderCount"
        Public Const GENERIC_XML_ORDER_CUSTOMER_ORDER_REF As String = "Order/CustomerOrderRef"
        Public Const GENERIC_XML_ORDER_SOURCE_ORDER_REF As String = "Order/SourceOrderRef"
        Public Const GENERIC_XML_ORDER_SOURCE_WEBSITE_REF As String = "Order/SourceWebSiteRef"
        Public Const GENERIC_XML_ORDER_SOURCE_MERCHANT_ID As String = "Order/SourceMerchantID" ' TJS 24/01/09
        Public Const GENERIC_XML_ORDER_PRICES_INCLUDE_TAX As String = "Order/PricesIncludeTax" ' TJS 08/06/09
        Public Const GENERIC_XML_ORDER_TAXCODE_FOR_SOURCE_TAX As String = "Order/TaxCodeForSourceTax" ' TJS 26/10/11
        Public Const GENERIC_XML_ORDER_DATE As String = "Order/OrderDate"
        Public Const GENERIC_XML_ORDER_CURRENCY As String = "Order/OrderCurrency"
        Public Const GENERIC_XML_ORDER_CUSTOMER_SALES_COUPON As String = "Order/CustomerSalesCoupon" ' TJS 09/03/096
        Public Const GENERIC_XML_ORDER_CUSTOMER_SALES_REP_GROUP_CODE As String = "Order/SalesRepGroupCode" ' RCD 2019/08/12
        Public Const GENERIC_XML_ORDER_CUSTOMER_SALES_REP_CODE As String = "Order/SalesRepCode" ' RCD 2019/08/15
        Public Const GENERIC_XML_ORDER_CUSTOMER_NOTES As String = "Order/Notes" ' RCD 2019/08/13
        Public Const GENERIC_XML_ORDER_CUSTOMER_SALES_AGENCY As String = "Order/SalesAgency" ' RCD 2019/08/13
        Public Const GENERIC_XML_ORDER_CUSTOMER_ORDER_TAKER As String = "Order/OrderTaker" ' RCD 2019/08/13
        Public Const GENERIC_XML_ORDER_CUSTOMER_BUYER_NAME As String = "Order/BuyerName" ' RCD 2019/08/13
        Public Const GENERIC_XML_ORDER_CUSTOMER_BUYER_PHONE As String = "Order/BuyerPhone" ' RCD 2019/08/13
        Public Const GENERIC_XML_ORDER_CUSTOMER_BUYER_EMAIL As String = "Order/BuyerEmail" ' RCD 2019/08/13
        Public Const GENERIC_XML_ORDER_CUSTOMER_CREDIT_CARD_TOKEN As String = "Order/CreditCardToken" ' RCD 2019/08/13
        Public Const GENERIC_XML_ORDER_UPDATE_CUSTOMER As String = "Order/UpdateCustomer" ' TJS/FA 09/07/11
        Public Const GENERIC_XML_ORDER_DISCOUNT_COUPON_DESCRIPTION As String = "Order/DiscountCoupon/DiscountDescription" ' TJS 08/06/09
        Public Const GENERIC_XML_ORDER_DISCOUNT_COUPON_VALUE As String = "Order/DiscountCoupon/DiscountValue" ' TJS 08/06/09
        Public Const GENERIC_XML_ORDER_CUSTOM_FIELDS As String = "Order/CustomField" ' TJS 03/04/09
        Public Const GENERIC_XML_ORDER_BILLING_DETAILS As String = "Order/BillingDetails"
        Public Const GENERIC_XML_ORDER_BILLING_DETAILS_CUSTOMER As String = GENERIC_XML_ORDER_BILLING_DETAILS & "/Customer"
        Public Const GENERIC_XML_ORDER_BILLING_DETAILS_ADDRESS As String = GENERIC_XML_ORDER_BILLING_DETAILS & "/BillingAddress"
        Public Const GENERIC_XML_ORDER_SHIPPING_DETAILS As String = "Order/ShippingDetails"
        Public Const GENERIC_XML_ORDER_SHIPPING_DETAILS_CUSTOMER As String = GENERIC_XML_ORDER_SHIPPING_DETAILS & "/Customer"
        Public Const GENERIC_XML_ORDER_SHIPPING_DETAILS_ADDRESS As String = GENERIC_XML_ORDER_SHIPPING_DETAILS & "/ShippingAddress"
        Public Const GENERIC_XML_ORDER_SHIPPING_DETAILS_METHOD As String = GENERIC_XML_ORDER_SHIPPING_DETAILS & "/ShippingMethod"
        Public Const GENERIC_XML_ORDER_SHIPPING_DETAILS_METHOD_GROUP As String = GENERIC_XML_ORDER_SHIPPING_DETAILS & "/ShippingMethodGroup"
        Public Const GENERIC_XML_ORDER_SHIPPING_DETAILS_SHIPPING_DATE As String = GENERIC_XML_ORDER_SHIPPING_DETAILS & "/ShippingDate" ' RCD 08/09/2019
        Public Const GENERIC_XML_ORDER_SHIPPING_DETAILS_LATEST_SHIPPING_DATE As String = GENERIC_XML_ORDER_SHIPPING_DETAILS & "/LatestShippingDate" ' RCD 08/12/2019
        Public Const GENERIC_XML_ORDER_PAYMENT_DETAILS_LIST As String = "Order/PaymentDetails" ' TJS 02/12/11
        Public Const GENERIC_XML_ORDER_PAYMENT_DETAILS As String = "PaymentDetails" ' TJS 02/12/11
        Public Const GENERIC_XML_ORDER_PAYMENT_METHOD As String = GENERIC_XML_ORDER_PAYMENT_DETAILS & "/PaymentMethod"
        Public Const GENERIC_XML_ORDER_CREDIT_CARD_DETAILS As String = GENERIC_XML_ORDER_PAYMENT_DETAILS & "/CreditCardDetails"
        Public Const GENERIC_XML_ORDER_CREDIT_CARD_TRANSACTION_STATUS As String = GENERIC_XML_ORDER_CREDIT_CARD_DETAILS & "/TransactionStatus" ' TJS 13/07/09
        Public Const GENERIC_XML_ORDER_TOTALS As String = "Order/OrderTotals"
        Public Const GENERIC_XML_ORDER_ITEM_LIST As String = "Order/Item"
        Public Const GENERIC_XML_ORDER_CUSTOMER_COMMENTS As String = "Order/CustomerComments"

        ' Generic XML Invoice Paths
        Public Const GENERIC_XML_INVOICE_LIST As String = "eShopCONNECT/Invoice"
        Public Const GENERIC_XML_INVOICE_COUNT As String = "eShopCONNECT/InvoiceCount"
        Public Const GENERIC_XML_INVOICE_CUSTOMER_ORDER_REF As String = "Invoice/CustomerOrderRef"
        Public Const GENERIC_XML_INVOICE_SOURCE_INVOICE_REF As String = "Invoice/SourceInvoiceRef"
        Public Const GENERIC_XML_INVOICE_SOURCE_WEBSITE_REF As String = "Invoice/SourceWebSiteRef"
        Public Const GENERIC_XML_INVOICE_SOURCE_MERCHANT_ID As String = "Invoice/SourceMerchantID" ' TJS 24/01/09
        Public Const GENERIC_XML_INVOICE_CUSTOMER_SALES_REP_GROUP_CODE As String = "Invoice/SalesRepGroupCode" ' RCD 2019/08/13
        Public Const GENERIC_XML_INVOICE_CUSTOMER_SALES_REP_CODE As String = "Invoice/SalesRepCode" ' RCD 2019/08/15
        Public Const GENERIC_XML_INVOICE_CUSTOMER_NOTES As String = "Invoice/Notes" ' RCD 2019/08/13
        Public Const GENERIC_XML_INVOICE_CUSTOMER_SALES_AGENCY As String = "Invoice/SalesAgency" ' RCD 2019/08/13
        Public Const GENERIC_XML_INVOICE_CUSTOMER_ORDER_TAKER As String = "Invoice/OrderTaker" ' RCD 2019/08/13
        Public Const GENERIC_XML_INVOICE_CUSTOMER_BUYER_NAME As String = "Invoice/BuyerName" ' RCD 2019/08/13
        Public Const GENERIC_XML_INVOICE_CUSTOMER_BUYER_PHONE As String = "Invoice/BuyerPhone" ' RCD 2019/08/13
        Public Const GENERIC_XML_INVOICE_CUSTOMER_BUYER_EMAIL As String = "Invoice/BuyerEmail" ' RCD 2019/08/13
        Public Const GENERIC_XML_INVOICE_CUSTOMER_CREDIT_CARD_TOKEN As String = "Invoice/CreditCardToken" ' RCD 2019/08/13
        Public Const GENERIC_XML_INVOICE_PRICES_INCLUDE_TAX As String = "Invoice/PricesIncludeTax" ' TJS 08/06/09
        Public Const GENERIC_XML_INVOICE_TAXCODE_FOR_SOURCE_TAX As String = "Invoice/TaxCodeForSourceTax" ' TJS 26/10/11
        Public Const GENERIC_XML_INVOICE_DATE As String = "Invoice/InvoiceDate"
        Public Const GENERIC_XML_INVOICE_CURRENCY As String = "Invoice/InvoiceCurrency"
        Public Const GENERIC_XML_INVOICE_UPDATE_CUSTOMER As String = "Invoice/UpdateCustomer" ' TJS/FA 09/07/11
        Public Const GENERIC_XML_INVOICE_CUSTOM_FIELDS As String = "Invoice/CustomField" ' TJS 03/04/09
        Public Const GENERIC_XML_INVOICE_BILLING_DETAILS As String = "Invoice/BillingDetails"
        Public Const GENERIC_XML_INVOICE_BILLING_DETAILS_CUSTOMER As String = GENERIC_XML_INVOICE_BILLING_DETAILS & "/Customer"
        Public Const GENERIC_XML_INVOICE_BILLING_DETAILS_ADDRESS As String = GENERIC_XML_INVOICE_BILLING_DETAILS & "/BillingAddress"
        Public Const GENERIC_XML_INVOICE_SHIPPING_DETAILS As String = "Invoice/ShippingDetails"
        Public Const GENERIC_XML_INVOICE_SHIPPING_DETAILS_CUSTOMER As String = GENERIC_XML_INVOICE_SHIPPING_DETAILS & "/Customer"
        Public Const GENERIC_XML_INVOICE_SHIPPING_DETAILS_ADDRESS As String = GENERIC_XML_INVOICE_SHIPPING_DETAILS & "/ShippingAddress"
        Public Const GENERIC_XML_INVOICE_SHIPPING_DETAILS_METHOD As String = GENERIC_XML_INVOICE_SHIPPING_DETAILS & "/ShippingMethod"
        Public Const GENERIC_XML_INVOICE_SHIPPING_DETAILS_METHOD_GROUP As String = GENERIC_XML_INVOICE_SHIPPING_DETAILS & "/ShippingMethodGroup"
        Public Const GENERIC_XML_INVOICE_SHIPPING_DETAILS_SHIPPING_DATE As String = GENERIC_XML_INVOICE_SHIPPING_DETAILS & "/ShippingDate"
        Public Const GENERIC_XML_INVOICE_SHIPPING_DETAILS_LATEST_SHIPPING_DATE As String = GENERIC_XML_INVOICE_SHIPPING_DETAILS & "/LatestShippingDate"
        Public Const GENERIC_XML_INVOICE_PAYMENT_DETAILS_LIST As String = "Invoice/PaymentDetails" ' TJS 26/10/11
        Public Const GENERIC_XML_INVOICE_PAYMENT_DETAILS As String = "PaymentDetails" ' TJS 02/12/11
        Public Const GENERIC_XML_INVOICE_PAYMENT_METHOD As String = GENERIC_XML_INVOICE_PAYMENT_DETAILS & "/PaymentMethod"
        Public Const GENERIC_XML_INVOICE_CREDIT_CARD_DETAILS As String = GENERIC_XML_INVOICE_PAYMENT_DETAILS & "/CreditCardDetails"
        Public Const GENERIC_XML_INVOICE_CREDIT_CARD_TRANSACTION_STATUS As String = GENERIC_XML_INVOICE_CREDIT_CARD_DETAILS & "/TransactionStatus" ' TJS 13/07/09
        Public Const GENERIC_XML_INVOICE_TOTALS As String = "Invoice/InvoiceTotals"
        Public Const GENERIC_XML_INVOICE_ITEM_LIST As String = "Invoice/Item"
        Public Const GENERIC_XML_INVOICE_CUSTOMER_COMMENTS As String = "Invoice/CustomerComments"
        Public Const GENERIC_XML_INVOICE_POST_INVOICE As String = "Invoice/PostInvoice" ' TJS 02/08/12

        ' Generic XML Credit Note Paths
        Public Const GENERIC_XML_CREDITNOTE_LIST As String = "eShopCONNECT/CreditNote"
        Public Const GENERIC_XML_CREDITNOTE_COUNT As String = "eShopCONNECT/CreditNoteCount"
        Public Const GENERIC_XML_CREDITNOTE_CUSTOMER_ORDER_REF As String = "CreditNote/CustomerOrderRef"
        Public Const GENERIC_XML_CREDITNOTE_SOURCE_CREDITNOTE_REF As String = "CreditNote/SourceCreditNoteRef"
        Public Const GENERIC_XML_CREDITNOTE_SOURCE_WEBSITE_REF As String = "CreditNote/SourceWebSiteRef"
        Public Const GENERIC_XML_CREDITNOTE_SOURCE_MERCHANT_ID As String = "CreditNote/SourceMerchantID" ' TJS 24/01/09
        Public Const GENERIC_XML_CREDITNOTE_PRICES_INCLUDE_TAX As String = "CreditNote/PricesIncludeTax" ' TJS 08/06/09
        Public Const GENERIC_XML_CREDITNOTE_TAXCODE_FOR_SOURCE_TAX As String = "CreditNote/TaxCodeForSourceTax" ' TJS 26/10/11
        Public Const GENERIC_XML_CREDITNOTE_DATE As String = "CreditNote/CreditNoteDate"
        Public Const GENERIC_XML_CREDITNOTE_CURRENCY As String = "CreditNote/CreditNoteCurrency"
        Public Const GENERIC_XML_CREDITNOTE_CUSTOM_FIELDS As String = "Invoice/CustomField" ' TJS 03/04/09
        Public Const GENERIC_XML_CREDITNOTE_BILLING_DETAILS As String = "CreditNote/BillingDetails"
        Public Const GENERIC_XML_CREDITNOTE_BILLING_DETAILS_CUSTOMER As String = GENERIC_XML_CREDITNOTE_BILLING_DETAILS & "/Customer"
        Public Const GENERIC_XML_CREDITNOTE_BILLING_DETAILS_ADDRESS As String = GENERIC_XML_CREDITNOTE_BILLING_DETAILS & "/BillingAddress"
        Public Const GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS As String = "CreditNote/ShippingDetails"
        Public Const GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS_CUSTOMER As String = GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS & "/Customer"
        Public Const GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS_ADDRESS As String = GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS & "/ShippingAddress"
        Public Const GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS_METHOD As String = GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS & "/ShippingMethod"
        Public Const GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS_METHOD_GROUP As String = GENERIC_XML_CREDITNOTE_SHIPPING_DETAILS & "/ShippingMethodGroup"
        Public Const GENERIC_XML_CREDITNOTE_TOTALS As String = "CreditNote/CreditNoteTotals"
        Public Const GENERIC_XML_CREDITNOTE_ITEM_LIST As String = "CreditNote/Item"
        Public Const GENERIC_XML_CREDITNOTE_CUSTOMER_COMMENTS As String = "CreditNote/CustomerComments"

        ' Generic XML Quote/Order/Invoice/CreditNote Item paths
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_PURCHASE_ID As String = "Item/SourceItemPurchaseID"
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_DESCRIPTION As String = "Item/ItemDescription"
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_CODE As String = "Item/ISItemCode"
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_NAME As String = "Item/ISItemName" ' TJs 11/02/09
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_UMC As String = "Item/ItemUnitOfMeasure" ' TJS 08/06/09
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_WAREHOUSE As String = "Item/ItemWarehouse" ' TJS 08/06/09
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_IS_DROP_SHIP As String = "Item/ItemDropShip" ' TJS 14/03/09
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_DROP_SHIP_REF As String = "Item/ItemDropShipReference" ' TJS 14/03/09
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_QUANTITY As String = "Item/ItemQuantity"
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_UNIT_PRICE As String = "Item/ItemUnitPrice"
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_SUB_TOTAL As String = "Item/ItemSubTotal"
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_TAX As String = "Item/ItemTaxValue"
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_TAX_RATE As String = "Item/ItemTaxRate"
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_CUSTOM_FIELDS As String = "Item/CustomField" ' TJS 03/04/09 TJS 02/12/11
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_SOURCE_COMMISSION As String = "Item/SourceItemCommission" ' TJS 10/06/12
        Public Const GENERIC_XML_ORDER_INVOICE_ITEM_SOURCE_FULFILLMENT As String = "Item/SourceItemFulfillmentCharge" ' TJS 10/06/12

        ' Generic XML lower case Import Types
        Public Const GENERIC_XML_QUOTE_IMPORT_TYPE As String = "quote" ' TJS 31/12/09
        Public Const GENERIC_XML_ORDER_IMPORT_TYPE As String = "order"
        Public Const GENERIC_XML_INVOICE_IMPORT_TYPE As String = "invoice"
        Public Const GENERIC_XML_CREDITNOTE_IMPORT_TYPE As String = "credit note"
        Public Const GENERIC_XML_LEAD_IMPORT_TYPE As String = "lead" ' TJS 13/07/09
        Public Const GENERIC_XML_PROSPECT_IMPORT_TYPE As String = "prospect" ' TJS 13/07/09
        Public Const GENERIC_XML_CUSTOMER_IMPORT_TYPE As String = "customer" ' TJS 13/07/09

        ' Generic XML Status Request Paths
        Public Const GENERIC_XML_STATUS_LIST As String = "eShopCONNECT/StatusRequest"
        Public Const GENERIC_XML_STATUS_COUNT As String = "eShopCONNECT/StatusRequestCount"
        Public Const GENERIC_XML_STATUS_CUSTOMER_ORDER_REF As String = "StatusRequest/CustomerOrderRef"
        Public Const GENERIC_XML_STATUS_SOURCE_ORDER_REF As String = "StatusRequest/SourceOrderRef"
        Public Const GENERIC_XML_STATUS_SOURCE_WEBSITE_REF As String = "StatusRequest/SourceWebSiteRef"
        Public Const GENERIC_XML_STATUS_SOURCE_MERCHANT_ID As String = "StatusRequest/SourceMerchantID" ' TJS 11/02/09
        Public Const GENERIC_XML_STATUS_SOURCE_CUSTOMER_ID As String = "StatusRequest/SourceCustomerID"
        Public Const GENERIC_XML_STATUS_IS_CUSTOMER_CODE As String = "StatusRequest/ISCustomerCode"
        Public Const GENERIC_XML_STATUS_RECORD_TYPE As String = "StatusRequest/RecordType"
        Public Const GENERIC_XML_STATUS_IS_RECORD_CODE As String = "StatusRequest/ISRecordCode"

        ' start of code added TJS 13/07/09 
        ' Generic XML Lead Paths
        Public Const GENERIC_XML_LEAD_LIST As String = "eShopCONNECT/Lead"
        Public Const GENERIC_XML_LEAD_SOURCE_LEAD_ID As String = "Lead/SourceLeadID"
        Public Const GENERIC_XML_LEAD_CONTACT_DETAILS As String = "Lead/LeadDetails/Contact"
        Public Const GENERIC_XML_LEAD_ADDRESS_DETAILS As String = "Lead/LeadDetails/Address"
        Public Const GENERIC_XML_LEAD As String = "Lead"
        Public Const GENERIC_XML_LEAD_ACTIVITY As String = "Lead/Activity"

        ' Generic XML Prospect Paths
        Public Const GENERIC_XML_PROSPECT_LIST As String = "eShopCONNECT/Prospect"
        Public Const GENERIC_XML_PROSPECT_SOURCE_PROSPECT_ID As String = "Prospect/SourceProspectID"
        Public Const GENERIC_XML_PROSPECT_NEW_CUSTOMER_CODE As String = "Prospect/NewISCustomerCode" ' TJS 19/08/10
        Public Const GENERIC_XML_PROSPECT_BILLING_CONTACT_DETAILS As String = "Prospect/BillingDetails/Contact"
        Public Const GENERIC_XML_PROSPECT_BILLING_ADDRESS_DETAILS As String = "Prospect/BillingDetails/BillingAddress" ' TJS 24/07/09
        Public Const GENERIC_XML_PROSPECT_SHIPPING_DETAILS As String = "Prospect/ShippingDetails"
        Public Const GENERIC_XML_PROSPECT_SHIPPING_CONTACT_DETAILS As String = GENERIC_XML_PROSPECT_SHIPPING_DETAILS & "/Contact"
        Public Const GENERIC_XML_PROSPECT_SHIPPING_ADDRESS_DETAILS As String = GENERIC_XML_PROSPECT_SHIPPING_DETAILS & "/ShippingAddress" ' TJS 24/07/09
        Public Const GENERIC_XML_PROSPECT_CURRENCY As String = "Prospect/TradingCurrency"
        Public Const GENERIC_XML_PROSPECT_ACTIVITY As String = "Prospect/Activity"

        ' Generic XML Customer Paths
        Public Const GENERIC_XML_CUSTOMER_LIST As String = "eShopCONNECT/Customer"
        Public Const GENERIC_XML_CUSTOMER_SOURCE_CUSTOMER_ID As String = "Customer/SourceCustomerID"
        Public Const GENERIC_XML_CUSTOMER_NEW_CUSTOMER_CODE As String = "Customer/NewISCustomerCode" ' TJS 19/08/10
        Public Const GENERIC_XML_CUSTOMER_BILLING_CONTACT_DETAILS As String = "Customer/BillingDetails/Contact"
        Public Const GENERIC_XML_CUSTOMER_BILLING_ADDRESS_DETAILS As String = "Customer/BillingDetails/BillingAddress" ' TJS 24/07/09
        Public Const GENERIC_XML_CUSTOMER_SHIPPING_DETAILS As String = "Customer/ShippingDetails"
        Public Const GENERIC_XML_CUSTOMER_SHIPPING_CONTACT_DETAILS As String = GENERIC_XML_CUSTOMER_SHIPPING_DETAILS & "/Contact"
        Public Const GENERIC_XML_CUSTOMER_SHIPPING_ADDRESS_DETAILS As String = GENERIC_XML_CUSTOMER_SHIPPING_DETAILS & "/ShippingAddress" ' TJS 24/07/09
        Public Const GENERIC_XML_CUSTOMER_CURRENCY As String = "Customer/TradingCurrency"
        Public Const GENERIC_XML_CUSTOMER_ACTIVITY As String = "Customer/Activity"

        ' Formatting and Validation - RCD 08/09/2019
        Public Const GENERIC_XML_YMD As String = "yyyy-MM-dd"
        Public Const GENERIC_XML_INVALID_SHIPPING_DATE As String = "Shipping Date Is Invalid! Should be yyyy-MM-dd."
        Public Const GENERIC_XML_INVALID_LATEST_SHIPPING_DATE As String = "Latest Shipping Date Is Invalid! Should be yyyy-MM-dd."
        ' end of code added TJS 13/07/09

        ' Shop.com Order XML paths
        Public Const SHOPDOTCOM_ORDER_LIST As String = "CC_TRANSMISSION/CC_ORDER"
        Public Const SHOPDOTCOM_ORDER_PAYMENT_METHOD As String = "CC_ORDER/PAYMENT_METHOD"
        Public Const SHOPDOTCOM_ORDER_PAYMENT_CARD_DETAILS As String = SHOPDOTCOM_ORDER_PAYMENT_METHOD & "/CREDIT_CARD"
        Public Const SHOPDOTCOM_ORDER_BILLING_LABEL As String = "CC_ORDER/BILLING_LABEL"
        Public Const SHOPDOTCOM_ORDER_BILLING_LABEL_CUSTOMER As String = SHOPDOTCOM_ORDER_BILLING_LABEL & "/CUSTOMER"
        Public Const SHOPDOTCOM_ORDER_BILLING_LABEL_ADDRESS As String = SHOPDOTCOM_ORDER_BILLING_LABEL & "/ADDRESS"
        Public Const SHOPDOTCOM_ORDER_SHIPPING_LABEL As String = "CC_ORDER/SHIPPING_LABEL"
        Public Const SHOPDOTCOM_ORDER_SHIPPING_LABEL_CUSTOMER As String = SHOPDOTCOM_ORDER_SHIPPING_LABEL & "/CUSTOMER"
        Public Const SHOPDOTCOM_ORDER_SHIPPING_LABEL_ADDRESS As String = SHOPDOTCOM_ORDER_SHIPPING_LABEL & "/ADDRESS"
        Public Const SHOPDOTCOM_ORDER_ITEM_LIST As String = "CC_ORDER/ITEMS/ITEM"
        Public Const SHOPDOTCOM_ORDER_ITEM As String = "ITEM"
        Public Const SHOPDOTCOM_ORDER_ITEM_SPECIAL_INTRUCT_LIST As String = "ITEM/SPECIAL_INSTRUCTIONS/SPECIAL_INSTRUCTION"
        Public Const SHOPDOTCOM_ORDER_ITEM_SPECIAL_INTRUCT As String = "SPECIAL_INSTRUCTION"
        Public Const SHOPDOTCOM_ORDER_TOTALS As String = "CC_ORDER/TOTALS"

        ' start of code added TJS 20/02/09 
        Public Const AMAZON_MESSAGE_TYPE As String = "AmazonEnvelope/MessageType"
        Public Const AMAZON_MESSAGE_MERCHANT_ID As String = "AmazonEnvelope/Header/MerchantIdentifier"
        Public Const AMAZON_ORDER_LIST As String = "AmazonEnvelope/Message/OrderReport"
        Public Const AMAZON_ORDER_DETAILS As String = "OrderReport/"
        Public Const AMAZON_ORDER_BILLING_DETAILS As String = "OrderReport/BillingData/"
        Public Const AMAZON_ORDER_BILLING_CARD_DETAILS As String = "OrderReport/BillingData/CreditCard/"
        Public Const AMAZON_ORDER_BILLING_CARD_ADDRESS_DETAILS As String = "OrderReport/BillingData/CreditCard/Address/"
        Public Const AMAZON_ORDER_FULFILLMENT_DETAILS As String = "OrderReport/FulfillmentData/"
        Public Const AMAZON_ORDER_FULFILLMENT_DETAILS_ADDRESS As String = "OrderReport/FulfillmentData/Address/"
        Public Const AMAZON_ORDER_ITEM_LIST As String = "OrderReport/Item"
        Public Const AMAZON_ORDER_ITEM_DETAILS As String = "Item/"
        Public Const AMAZON_ORDER_ITEM_PRICE_COMPONENT_LIST As String = "Item/ItemPrice/Component"
        Public Const AMAZON_ORDER_ITEM_PRICE_COMPONENT_DETAILS As String = "Component/"
        Public Const AMAZON_ORDER_ITEM_FEE_DETAILS As String = "Item/ItemFees/Fee/" ' TJS 09/03/09
        Public Const AMAZON_REPORT_ERROR_LIST As String = "AmazonEnvelope/Message/ProcessingReport/Result" ' TJS 06/10/09
        Public Const AMAZON_REPORT_SUMMARY As String = "AmazonEnvelope/Message/ProcessingReport/ProcessingSummary" ' TJS 15/12/09
        Public Const AMAZON_REPORT_ERROR_DETAILS As String = "Result/" ' TJS 06/10/09
        ' end of code added TJS 20/02/09 
        ' start of code added TJS 05/07/12
        Public Const AMAZON_SETTLEMENT_REPORT_DATA As String = "AmazonEnvelope/Message/SettlementReport/SettlementData/"
        Public Const AMAZON_SETTLEMENT_ORDER_LIST As String = "AmazonEnvelope/Message/SettlementReport/Order"
        Public Const AMAZON_SETTLEMENT_ORDER_DETAILS As String = "Order/"
        Public Const AMAZON_SETTLEMENT_ORDER_FULFILLMENT_DETAILS As String = "Order/Fulfillment/"
        Public Const AMAZON_SETTLEMENT_ORDER_FULFILLMENT_ITEM_LIST As String = "Order/Fulfillment/Item"
        Public Const AMAZON_SETTLEMENT_ORDER_FULFILLMENT_ITEM_DETAILS As String = "Item/"
        Public Const AMAZON_SETTLEMENT_ADJUSTMENT_LIST As String = "AmazonEnvelope/Message/SettlementReport/Adjustment"
        Public Const AMAZON_SETTLEMENT_ADJUSTMENT_DETAILS As String = "Adjustment/"
        Public Const AMAZON_SETTLEMENT_ADJUSTMENT_FULFILLMENT_DETAILS As String = "Adjustment/Fulfillment/"
        Public Const AMAZON_SETTLEMENT_ADJUSTMENT_FULFILLMENT_ITEM_LIST As String = "Adjustment/Fulfillment/AdjustedItem"
        Public Const AMAZON_SETTLEMENT_ADJUSTMENT_FULFILLMENT_ITEM_DETAILS As String = "AdjustedItem/"
        Public Const AMAZON_SETTLEMENT_OTHER_TRANSACTION_LIST As String = "AmazonEnvelope/Message/SettlementReport/OtherTransaction"
        Public Const AMAZON_SETTLEMENT_OTHER_TRANSACTION_DETAILS As String = "OtherTransaction/"
        ' end of code added TJS 05/07/12

        ' start of code added TJS 13/07/09 
        ' Volusion Order XML paths
        Public Const VOLUSION_ORDER_LIST As String = "xmldata/Orders"
        Public Const VOLUSION_ORDER_HEADER As String = "Orders/"
        Public Const VOLUSION_ORDER_ITEM_LIST As String = "Orders/OrderDetails"
        Public Const VOLUSION_ORDER_ITEM_DETAILS As String = "OrderDetails/"
        ' end of code added TJS 13/07/09 

        ' start of code added TJS 15/12/09 
        ' Channel Advisor Order XML Paths
        Public Const CHANNEL_ADV_ORDER_LIST As String = "soap:Envelope/soap:Body/GetOrderListResponse/GetOrderListResult/ResultData/OrderResponseItem" ' TJS 31/12/09
        Public Const CHANNEL_ADV_ORDER_DETAILS As String = "OrderResponseItem/"
        Public Const CHANNEL_ADV_ORDER_STATUS As String = "OrderResponseItem/q1:OrderStatus/" ' TJS 18/12/09
        Public Const CHANNEL_ADV_ORDER_BILLING_DETAILS As String = "OrderResponseItem/q1:BillingInfo/"
        Public Const CHANNEL_ADV_ORDER_SHIPPING_DETAILS As String = "OrderResponseItem/q1:ShippingInfo/"
        Public Const CHANNEL_ADV_ORDER_SHIPPING_DETAILS_METHOD As String = "OrderResponseItem/q1:ShippingInfo/q1:ShipmentList/q1:Shipment/"
        Public Const CHANNEL_ADV_ORDER_PAYMENT_DETAILS As String = "OrderResponseItem/q1:PaymentInfo/" ' TJS 22/09/10
        Public Const CHANNEL_ADV_ORDER_SHOPPING_CART As String = "OrderResponseItem/q1:ShoppingCart/"
        Public Const CHANNEL_ADV_ORDER_ITEM_LIST As String = "OrderResponseItem/q1:ShoppingCart/q1:LineItemSKUList/q1:OrderLineItemItem"
        Public Const CHANNEL_ADV_ORDER_ITEM_DETAILS As String = "q1:OrderLineItemItem/"
        Public Const CHANNEL_ADV_ORDER_ITEM_PRICE_LIST As String = "OrderResponseItem/q1:ShoppingCart/q1:LineItemInvoiceList/q1:OrderLineItemInvoice"
        Public Const CHANNEL_ADV_ORDER_ITEM_PRICE_DETAILS As String = "q1:OrderLineItemInvoice/"
        ' end of code added TJS 15/12/09 

        ' ASPDotNetStorefront Order XML Paths
        Public Const ASPDOTNETSTOREFRONT_ORDER_LIST As String = "AspDotNetStorefrontImportResult//Order" ' TJS 19/08/10
        Public Const ASPDOTNETSTOREFRONT_ORDER_HEADER As String = "Order/" ' TJS 19/08/10
        Public Const ASPDOTNETSTOREFRONT_ORDER_ITEM_LIST As String = "Order/OrderItems/Item" ' TJS 19/08/10
        Public Const ASPDOTNETSTOREFRONT_ORDER_ITEM_DETAILS As String = "Item/" ' TJS 19/08/10

        ' start of code added TJS 02/12/11 
        ' eBay Order XML Paths
        Public Const EBAY_ORDER_LIST As String = "GetOrdersResponse/OrderArray/Order"
        Public Const EBAY_ORDER_DETAILS As String = "Order/"
        Public Const EBAY_ORDER_SHIPPING_DETAILS As String = "Order/ShippingAddress/"
        Public Const EBAY_ORDER_ITEM_LIST As String = "Order/TransactionArray/Transaction"
        Public Const EBAY_ORDER_ITEM_DETAILS As String = "Transaction/"
        Public Const EBAY_ORDER_CHECKOUT_DETAILS As String = "Order/CheckoutStatus"
        Public Const EBAY_ORDER_PAYMENT_DETAILS_LIST As String = "Order/ExternalTransaction"
        Public Const EBAY_ORDER_PAYMENT_DETAILS As String = "ExternalTransaction/"
        Public Const EBAY_ORDER_SHIPPING_DETAILS_METHOD As String = "Order/ShippingServiceSelected/"
        ' end of code added TJS 02/12/11 

        ' start of code added TJS 16/01/12
        ' Sears.com Order XML paths
        Public Const SEARSDOTCOM_ORDER_LIST As String = "po-response/purchase-order"
        Public Const SEARSDOTCOM_ORDER_HEADER As String = "purchase-order/"
        Public Const SEARSDOTCOM_SHIPPING_DETAIL As String = "purchase-order/shipping-detail/"
        Public Const SEARSDOTCOM_ORDER_ITEM_LIST As String = "purchase-order/po-line"
        Public Const SEARSDOTCOM_ORDER_ITEM_HEADER As String = "po-line/po-line-header/"
        Public Const SEARSDOTCOM_ORDER_ITEM_DETAIL As String = "po-line/po-line-detail/"
        ' end of code added TJS 16/01/12

        ' start of code added TJS 20/11/13
        Public Const THREE_D_CART_ORDER_LIST As String = "soap:Envelope/soap:Body/getOrderResponse/getOrderResult/GetOrdersResponse/Order"
        Public Const THREE_D_CART_ORDER_HEADER As String = "Order/"
        Public Const THREE_D_CART_ORDER_BILLING_DETAILS As String = "Order/BillingAddress/"
        Public Const THREE_D_CART_ORDER_SHIPMENT_LIST As String = "Order/ShippingInformation/Shipment"
        Public Const THREE_D_CART_ORDER_SHIPMENT_DETAILS As String = "Shipment/"
        Public Const THREE_D_CART_ORDER_ITEM_LIST As String = "Order/ShippingInformation/OrderItems/Item"
        Public Const THREE_D_CART_ORDER_ITEM_DETAILS As String = "Item/"
        ' end of code added TJS 20/11/13

        ' Shop.com Status Update paths
        Public Const SHOPDOTCOM_STATUS_UPDATE_HEADER As String = "ADI_OS_ORDER_STATUS_TRANSMISSION/ADI_OS_HEADER" ' TJS 06/02/09
        Public Const SHOPDOTCOM_STATUS_UPDATE_ORDER_STATUS As String = "ADI_OS_ORDER_STATUS_TRANSMISSION/ADI_OS_STATUS" ' TJS 06/02/09

        ' Amazon Status Update paths
        Public Const AMAZON_STATUS_UPDATE_HEADER As String = "AmazonEnvelope/Header" ' TJS 09/03/09
        Public Const AMAZON_STATUS_UPDATE_MESSAGE_TYPE As String = "AmazonEnvelope/MessageType" ' TJS 09/03/09

        ' Channel Advisor Status Update paths
        Public Const CHANNEL_ADV_STATUS_UPDATE_HEADER As String = "soapenv:Envelope/soapenv:Header" ' TJS 06/02/09
        Public Const CHANNEL_ADV_STATUS_SET_ORDER_EXPORT_STATUS As String = "soapenv:Envelope/soapenv:Body/web:SetOrdersExportStatus/web:orderIDList/" ' TJS 31/12/09 TJS 02/04/14
        Public Const CHANNEL_ADV_STATUS_SET_SELLER_ORDER_ID As String = "soapenv:Envelope/soapenv:Body/SetSellerOrderID/" ' TJS 31/12/09
        Public Const CHANNEL_ADV_STATUS_ORDER_SHIPPED As String = "soapenv:Envelope/soapenv:Body/OrderShipped/" ' TJS 31/12/09
        Public Const CHANNEL_ADV_STATUS_SUBMIT_ORDER_SHIPMENT_LIST As String = "soapenv:Envelope/soapenv:Body/SubmitOrderShipmentList/" ' TJS 31/12/09

        ' Shop.com Status Update response paths
        Public Const SHOPDOTCOM_STATUS_RESPONSE_ORDER As String = "CC_TRANSMISSION_RESPONSE/ORDER" ' TJS 06/02/09
        Public Const SHOPDOTCOM_STATUS_RESPONSE_STATUS As String = "CC_TRANSMISSION_RESPONSE/STATUS" ' TJS 06/02/09

        ' Channel Advisor Status Update response paths
        Public Const CHANNEL_ADV_STATUS_RESPONSE_SET_ORDER_EXPORT_STATUS As String = "soap:Envelope/soap:Body/SetOrdersExportStatusResponse/SetOrdersExportStatusResult/" ' TJS 31/12/09
        Public Const CHANNEL_ADV_STATUS_RESPONSE_SET_SELLER_ORDER_ID As String = "soap:Envelope/soap:Body/SetSellerOrderIDResponse/SetSellerOrderIDResult/" ' TJS 31/12/09
        Public Const CHANNEL_ADV_STATUS_RESPONSE_ORDER_SHIPPED As String = "soap:Envelope/soap:Body/OrderShippedResponse/OrderShippedResult/" ' TJS 31/12/09
        Public Const CHANNEL_ADV_STATUS_RESPONSE_SUBMIT_ORDER_SHIPMENT_LIST As String = "soap:Envelope/soap:Body/SubmitOrderShipmentListResponse/SubmitOrderShipmentListResult/" ' TJS 31/12/09

        Public Const LOG_MESSAGE_TYPE_PROGRESS As String = "Progress"
        Public Const LOG_MESSAGE_TYPE_WARNING As String = "!Warning"
        Public Const LOG_MESSAGE_TYPE_ERROR As String = "!Error!!"
        Public Const LOG_MESSAGE_TYPE_SOURCE_ERROR As String = "!SrcErr!"
        Public Const LOG_MESSAGE_TYPE_SOURCE_INFO As String = "!SrcInfo!"

        'Stored Procedure Parameter
        Public Const AT_PRODUCT_CODE As String = "@ProductCode"
        Public Const AT_SOURCE_CODE As String = "@SourceCode"
        Public Const AT_PO_CODE As String = "@POCode"
        Public Const AT_MERCHANT_ORDER_CODE As String = "@MerchantOrderCode" ' TJS 06/02/09
        Public Const AT_SOURCE_DELIVERY_METHOD As String = "@SourceDeliveryMethod"
        Public Const AT_SOURCE_DELIVERY_CLASS As String = "@SourceDeliveryClass" ' TJS 15/12/09
        Public Const AT_SOURCE_PAYMENT_TYPE As String = "@SourcePaymentType" ' TJS 22/09/10
        Public Const AT_SHIP_TO_CODE As String = "@ShipToCode"
        Public Const AT_COUNTRY_CODE As String = "@CountryCode"
        Public Const AT_ITEM_NAME As String = "@ItemName" ' TJS 11/02/09
        Public Const AT_IMPORT_CUSTOMER_ID As String = "@ImportCustomerID"
        Public Const AT_IMPORT_LEAD_ID As String = "@ImportLeadID" ' TJS 13/07/09
        Public Const AT_IMPORT_SOURCE_ID As String = "@ImportSourceID"
        Public Const AT_CREDIT_CARD_TYPE As String = "@CreditCardType" ' TJS 02/02/09
        Public Const AT_PAYMENT_TYPE_CODE As String = "@PaymentTypeCode" ' TJS 02/02/09
        Public Const AT_ACTION_COMPLETE As String = "@ActionComplete" ' TJS 02/02/09
        Public Const AT_XML_TO_SEND As String = "@XMLToSend" ' TJS 06/02/09
        Public Const AT_SALES_ORDER_CODE As String = "@SalesOrderCode" ' TJS 06/02/09
        Public Const AT_INVOICE_CODE As String = "@InvoiceCode" ' TJS 06/02/09
        Public Const AT_LINE_NUM As String = "@LineNum" ' TJS 06/02/09
        Public Const AT_SHIPPING_METHOD As String = "@ShippingMethodCode" ' TJS 06/02/09
        Public Const AT_SHIPPING_METHOD_GROUP As String = "@ShippingMethodGroup" ' TJS 06/02/09
        Public Const AT_WEBSITE_CODE As String = "@WebSiteCode" ' TJS 11/02/09
        Public Const AT_SOURCE_CUSTOMER_ID As String = "@SourceCustomerID" ' TJS 11/02/09
        Public Const AT_STORE_MERCHANT_ID As String = "@StoreMerchantID" ' TJS 11/02/09
        Public Const AT_MERCHANT_ORDER_ID As String = "@MerchantOrderID" ' TJs 10/06/12
        Public Const AT_ISO_CODE As String = "@ISOCode"
        Public Const AT_COUPON_CODE As String = "@CouponCode" ' TJS 09/03/09
        Public Const AT_SITE_CODE As String = "@SiteCode" ' TJS 30/04/09
        Public Const AT_PARENT_NODE As String = "@ParentNode" ' TJS 30/04/09
        Public Const AT_PARENT_CATEGORY As String = "@ParentCategory" ' TJS 30/04/09
        Public Const AT_IS_VOIDED As String = "@IsVoided" ' TJS 11/05/09
        Public Const AT_TAG_LOCATION As String = "@TagLocation" ' TJS 21/05/09
        Public Const AT_EXCLUDE_TAG_LOCATION As String = "@ExcludeTagLocation" ' TJS 21/05/09
        Public Const AT_NODE_ID As String = "@NodeID" ' TJS 13/07/09
        Public Const AT_ATTRIBUTE_CATEGORY_STRING As String = "@AttributeCategoryString" ' TJS 13/07/09
        Public Const AT_SOURCE_INVOICE_CODE As String = "@SourceInvoiceCode" ' TJS 26/08/09
        Public Const AT_MATRIX_GROUP_ITEM_CODE As String = "@MatrixGroupItemCode" ' TJS 06/10/09
        Public Const AT_AMAZON_FILE_ID As String = "@AmazonFileID" ' TJS 14/11/09
        Public Const AT_FILE_NAME As String = "@FileName" ' TJS 14/11/09
        Public Const AT_FILE_SENT_TO_AMAZON As String = "@FileSentToAmazon" ' TJS 14/11/09
        Public Const AT_FILE_ACKNOWLEDGED As String = "@FileAcknowledged" ' TJS 14/11/09
        Public Const AT_FILE_RESPONSE_RECEIVED As String = "@ResponseReceived" ' TJS 14/11/09
        Public Const AT_CONTACT_CODE As String = "@ContactCode" ' TJS 19/08/10
        Public Const AT_ENTITY_CODE As String = "@EntityCode" ' TJS 19/08/10
        Public Const AT_IS_ACTIVE As String = "@IsActive" ' TJS 19/08/10
        Public Const AT_LICENCE_CODE As String = "@LicenceCode" ' TJS 18/03/11
        Public Const AT_SITE_ID As String = "@SiteID" ' TJS 18/03/11
        Public Const AT_INSTANCE_ID As String = "@InstanceID" ' TJS 18/03/11
        Public Const AT_MANUFACTURER_CODE As String = "@ManufacturerCode" ' TJS 18/03/11
        Public Const AT_ADDITIONAL_FILTER As String = "@AdditionalFilter" ' TJS 18/03/11
        Public Const AT_COUNTRY_ID As String = "@CountryID" ' TJS 02/12/11
        Public Const AT_ACCOUNT_ID As String = "@AccountID" ' TJS 02/12/11
        Public Const AT_SETTLEMENT_CODE As String = "@SettlementCode" ' TJS 05/07/12
        Public Const AT_IGNORE_RETRY_TIME_AND_COUNT As String = "@IgnoreRetryTimeAndCount" ' TJS 10/06/12
        Public Const AT_AMAZON_MESSAGE_TYPE As String = "@AmazonMessageType" ' TJS 05/07/12
        Public Const AT_AMAZON_DOCUMENT_ID As String = "@AmazonDocumentID" ' TJS 05/07/12
        Public Const AT_MERCHANT_ID As String = "@MerchantID" ' TJS 05/07/12
        Public Const AT_ATTRIBUTE_USAGE As String = "@AttributeUse" ' TJS 13/11/13
        Public Const AT_ATTRIBUTE_ALT_USAGE As String = "@AlternateUse" ' TJS 13/11/13
        Public Const AT_STORE_ID As String = "@StoreID" ' TJS 20/11/13

        ' Amazon Inventory Publishing constants
        Public Const AMAZON_ROOT_CATEGORY As String = "-100" ' TJS 23/05/09
        Public Const AMAZON_SEARCH_TERM_TAG_LOCATION As String = "10" ' TJS 23/05/09
        Public Const AMAZON_CORE_TAG_LOCATION As String = "1" ' TJS 06/10/09
        Public Const AMAZON_VARIATION_TAG_LOCATION As String = "2" ' TJS 06/10/09
        Public Const AMAZON_CLASSIFICATION_DATA_TAG_LOCATION As String = "3" ' TJS 06/10/09
        Public Const AMAZON_PRODUCT_DATA_TAG_LOCATION As String = "4" ' TJS 06/10/09
        Public Const AMAZON_INVENTORY_TAG_LOCATION As String = "20" ' TJS 06/10/09

        ' Shop.com Inventory Publishing constants
        Public Const SHOPCOM_ROOT_ATTRIBUTE_CATEGORY As String = "root" ' TJS 08/06/09
        Public Const SHOPCOM_ROOT_CATEGORY As String = "-100" ' TJS 08/06/09

        ' CB Item Bundle constants
        Public Const PARENTBUNDLEITEMCODE As String = "ParentBundleItemCode" ' TJS 02/04/14
        Public Const BUNDLECODE As String = "BundleCode" ' TJS 02/04/14

        'CB Bypass Activation
        Public Const CB_ACTIVATION As Boolean = True ' Mark Kee 06/11/2015
        Public Const CB_ADDSTRFILTER As String = "and IsActive = 1" ' Mark Kee 06/11/2015


        Public Structure ChannelAdvCarrier ' TJS 27/09/10
            Public CarrierName As String
            Public CarrierCode As String
            Public ClassCode As String
            Public ClassName As String
        End Structure
    End Module
End Namespace