///////////////////////////////////////////////////////////////////////////
// Description: Entity class for the 'INVOICE'
// Generated by VNYI GenTool.
// Copyright (c) YI Corp. All rights reserved.// Design by ngocchinh.//email:ngocchinh4984@gmail.com
///////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

using System.Data;

namespace vnyi.Library.COMON.IV
{
    public class INVOICE : vnyi.Library.DOC.PUBDOCUMENT
    {

        public static string COLUMN_IV_DOCUMENTID = "IV_DOCUMENTID";
        public static string COLUMN_IV_ISINVOICEVAT = "IV_ISINVOICEVAT";
        public static string COLUMN_IV_ISUSE = "IV_ISUSE";
        public static string COLUMN_IV_ISPOST = "IV_ISPOST";
        public static string COLUMN_PTE_DUEDATE = "PTE_DUEDATE";
        public static string COLUMN_IV_REDUCEAMOUNT = "IV_REDUCEAMOUNT";
        public static string COLUMN_IV_ITEMAMOUNT = "IV_ITEMAMOUNT";
        public static string COLUMN_IV_CURENTCYRATE = "IV_CURENTCYRATE";
        public static string COLUMN_IV_REDUCEBASEAMOUNT = "IV_REDUCEBASEAMOUNT";
        public static string COLUMN_IV_ITEMBASEAMOUNT = "IV_ITEMBASEAMOUNT";
        public static string COLUMN_IV_DISCOUNTPER = "IV_DISCOUNTPER";
        public static string COLUMN_IV_DISAMOUNT = "IV_DISAMOUNT";
        public static string COLUMN_IV_DISBASEAMOUNT = "IV_DISBASEAMOUNT";
        public static string COLUMN_IV_VATBASEAMOUNT = "IV_VATBASEAMOUNT";
        public static string COLUMN_IV_BASEAMOUNT = "IV_BASEAMOUNT";
        public static string COLUMN_IV_AMOUNT = "IV_AMOUNT";
        public static string COLUMN_IV_VATAMOUNT = "IV_VATAMOUNT";
        public static string COLUMN_IV_BALANCE = "IV_BALANCE";
        public static string COLUMN_IV_EXCISETAXBASEAMOUNT = "IV_EXCISETAXBASEAMOUNT";
        public static string COLUMN_IV_EXCISETAXAMOUNT = "IV_EXCISETAXAMOUNT";
        public static string COLUMN_IV_IMEXPORTTAXBASEAMOUNT = "IV_IMEXPORTTAXBASEAMOUNT";
        public static string COLUMN_IV_IMEXPORTTAXAMOUNT = "IV_IMEXPORTTAXAMOUNT";
        public static string COLUMN_OBJ_AUTOID = "OBJ_AUTOID";
        public static string COLUMN_OBJ_NAME = "OBJ_NAME";
        public static string COLUMN_Obj_TaxID = "Obj_TaxID";
        public static string COLUMN_Obj_Address = "Obj_Address";
        public static string COLUMN_IV_DOCUMENTNUM = "IV_DOCUMENTNUM";
        public static string COLUMN_PTE_DESCRIPTION = "PTE_DESCRIPTION";
        public static string COLUMN_PTE_AUTOID = "PTE_AUTOID";
        public static string COLUMN_TR_AUTOID = "TR_AUTOID";
        public static string COLUMN_CUR_AUTOID = "CUR_AUTOID";
        public static string COLUMN_DOTY_AUTOID = "DOTY_AUTOID";
        public static string COLUMN_IV_USEIN = "IV_USEIN";
        public static string COLUMN_ST_AUTOID = "ST_AUTOID";
        public static string COLUMN_FICI_AUTOID = "FICI_AUTOID";
        public static string COLUMN_IV_TYPE = "IV_TYPE";
        public static string COLUMN_IV_SIGNEDBILL = "IV_SIGNEDBILL";

        public static string TABLE_NAME = "INVOICE";

        public Nullable<Int64> IV_DOCUMENTID
        {
            get
            {
                return ConvertToInt64(_dataRow[COLUMN_IV_DOCUMENTID]);
            }
            set
            {
                _dataRow[COLUMN_IV_DOCUMENTID] = value;
            }
        }
        public String IV_DOCUMENTNUM
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_IV_DOCUMENTNUM], null));
            }
            set
            {
                _dataRow[COLUMN_IV_DOCUMENTNUM] = value;
            }
        }
        public String OBJ_NAME
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_OBJ_NAME], null));
            }
            set
            {
                _dataRow[COLUMN_OBJ_NAME] = value;
            }
        }
        public String Obj_TaxID
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_Obj_TaxID], null));
            }
            set
            {
                _dataRow[COLUMN_Obj_TaxID] = value;
            }
        }
        public String Obj_Address
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_Obj_Address], null));
            }
            set
            {
                _dataRow[COLUMN_Obj_Address] = value;
            }
        }
        public Nullable<Int16> IV_TYPE
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_IV_TYPE]);
            }
            set
            {
                _dataRow[COLUMN_IV_TYPE] = value;
            }
        }
        public Nullable<Int16> FICI_AUTOID
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_FICI_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_FICI_AUTOID] = value;
            }
        }
        public Nullable<Int16> TR_AUTOID
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_TR_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_TR_AUTOID] = value;
            }
        }
        public Nullable<Int16> CUR_AUTOID
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_CUR_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_CUR_AUTOID] = value;
            }
        }
        public Nullable<int> OBJ_AUTOID
        {
            get
            {
                return ConvertToInt32(_dataRow[COLUMN_OBJ_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_OBJ_AUTOID] = value;
            }
        }
        public Nullable<Int16> DOTY_AUTOID
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_DOTY_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_DOTY_AUTOID] = value;
            }
        }
        public String IV_SIGNEDBILL
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_IV_SIGNEDBILL], null));
            }
            set
            {
                _dataRow[COLUMN_IV_SIGNEDBILL] = value;
            }
        }
        public Nullable<Int16> PTE_AUTOID
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_PTE_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_PTE_AUTOID] = value;
            }
        }
        public bool IV_ISUSE
        {
            get
            {
                return ConvertToBoolean(_dataRow[COLUMN_IV_ISUSE]);
            }
            set
            {
                _dataRow[COLUMN_IV_ISUSE] = value;
            }
        }
        public bool IV_ISINVOICEVAT
        {
            get
            {
                return ConvertToBoolean(_dataRow[COLUMN_IV_ISINVOICEVAT]);
            }
            set
            {
                _dataRow[COLUMN_IV_ISINVOICEVAT] = value;
            }
        }
        public bool IV_ISPOST
        {
            get
            {
                return ConvertToBoolean(_dataRow[COLUMN_IV_ISPOST]);
            }
            set
            {
                _dataRow[COLUMN_IV_ISPOST] = value;
            }
        }
        public Nullable<Int16> ST_AUTOID
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_ST_AUTOID]);
            }
            set
            {
                _dataRow[COLUMN_ST_AUTOID] = value;
            }
        }
        public Nullable<Decimal> IV_CURENTCYRATE
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_CURENTCYRATE]);
            }
            set
            {
                _dataRow[COLUMN_IV_CURENTCYRATE] = value;
            }
        }
        public Nullable<Int16> IV_USEIN
        {
            get
            {
                return ConvertToInt16(_dataRow[COLUMN_IV_USEIN]);
            }
            set
            {
                _dataRow[COLUMN_IV_USEIN] = value;
            }
        }
        public Nullable<DateTime> PTE_DUEDATE
        {
            get
            {
                return ConvertToDateTime(_dataRow[COLUMN_PTE_DUEDATE]);
            }
            set
            {
                _dataRow[COLUMN_PTE_DUEDATE] = value;
            }
        }
        public Nullable<Decimal> IV_ITEMAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_ITEMAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_ITEMAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_ITEMBASEAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_ITEMBASEAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_ITEMBASEAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_VATAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_VATAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_VATAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_VATBASEAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_VATBASEAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_VATBASEAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_DISCOUNTPER
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_DISCOUNTPER]);
            }
            set
            {
                _dataRow[COLUMN_IV_DISCOUNTPER] = value;
            }
        }
        public Nullable<Decimal> IV_DISAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_DISAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_DISAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_DISBASEAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_DISBASEAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_DISBASEAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_REDUCEAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_REDUCEAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_REDUCEAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_REDUCEBASEAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_REDUCEBASEAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_REDUCEBASEAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_EXCISETAXAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_EXCISETAXAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_EXCISETAXAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_EXCISETAXBASEAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_EXCISETAXBASEAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_EXCISETAXBASEAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_IMEXPORTTAXAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_IMEXPORTTAXAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_IMEXPORTTAXAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_IMEXPORTTAXBASEAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_IMEXPORTTAXBASEAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_IMEXPORTTAXBASEAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_AMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_AMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_AMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_BASEAMOUNT
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_BASEAMOUNT]);
            }
            set
            {
                _dataRow[COLUMN_IV_BASEAMOUNT] = value;
            }
        }
        public Nullable<Decimal> IV_BALANCE
        {
            get
            {
                return ConvertDecimalnull(_dataRow[COLUMN_IV_BALANCE]);
            }
            set
            {
                _dataRow[COLUMN_IV_BALANCE] = value;
            }
        }
        public String PTE_DESCRIPTION
        {
            get
            {
                return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_PTE_DESCRIPTION], null));
            }
            set
            {
                _dataRow[COLUMN_PTE_DESCRIPTION] = value;
            }
        }
        public INVOICE(IDataReader RederObject) : base(RederObject, TABLE_NAME) { }
        public INVOICE(DataRow row) : base(row, TABLE_NAME) { }
        public INVOICE()
            : base(TABLE_NAME, COLUMN_IV_DOCUMENTID,
            COLUMN_IV_DOCUMENTNUM,
            COLUMN_IV_TYPE,
            COLUMN_FICI_AUTOID,
            COLUMN_TR_AUTOID,
            COLUMN_CUR_AUTOID,
            COLUMN_OBJ_AUTOID,
            COLUMN_OBJ_NAME,
            COLUMN_Obj_TaxID,
            COLUMN_Obj_Address,
            COLUMN_DOTY_AUTOID,
            COLUMN_IV_SIGNEDBILL,
            COLUMN_PTE_AUTOID,
            COLUMN_IV_ISUSE,
            COLUMN_IV_ISINVOICEVAT,
            COLUMN_IV_ISPOST,
            COLUMN_ST_AUTOID,
            COLUMN_IV_CURENTCYRATE,
            COLUMN_IV_USEIN,
            COLUMN_PTE_DUEDATE,
            COLUMN_IV_ITEMAMOUNT,
            COLUMN_IV_ITEMBASEAMOUNT,
            COLUMN_IV_VATAMOUNT,
            COLUMN_IV_VATBASEAMOUNT,
            COLUMN_IV_DISCOUNTPER,
            COLUMN_IV_DISAMOUNT,
            COLUMN_IV_DISBASEAMOUNT,
            COLUMN_IV_REDUCEAMOUNT,
            COLUMN_IV_REDUCEBASEAMOUNT,
            COLUMN_IV_EXCISETAXAMOUNT,
            COLUMN_IV_EXCISETAXBASEAMOUNT,
            COLUMN_IV_IMEXPORTTAXAMOUNT,
            COLUMN_IV_IMEXPORTTAXBASEAMOUNT,
            COLUMN_IV_AMOUNT,
            COLUMN_IV_BASEAMOUNT,
            COLUMN_IV_BALANCE,
            COLUMN_PTE_DESCRIPTION) { }
    }
}

