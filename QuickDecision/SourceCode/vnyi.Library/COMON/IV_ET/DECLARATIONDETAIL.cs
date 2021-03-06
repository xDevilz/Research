///////////////////////////////////////////////////////////////////////////
// Description: Entity class for the 'DECLARATIONDETAIL'
// Generated by VNYI GenTool.
// Copyright (c) YI Corp. All rights reserved.// Design by ngocchinh.//email:ngocchinh4984@gmail.com
///////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

using System.Data;

namespace vnyi.Library.COMON.IV
{
public class DECLARATIONDETAIL : vnyi.DLL.DataObject
	{

public static string COLUMN_DEC_DOCUMENTID="DEC_DOCUMENTID";
public static string COLUMN_DOC_DOCUMENTID="DOC_DOCUMENTID";
public static string COLUMN_DECD_AUTOID="DECD_AUTOID";
public static string COLUMN_DECD_QUANTITY="DECD_QUANTITY";
public static string COLUMN_DECD_AMOUNT="DECD_AMOUNT";
public static string COLUMN_PIT_UNITPRICE="PIT_UNITPRICE";
public static string COLUMN_DECD_POIVQUANTITY="DECD_POIVQUANTITY";
public static string COLUMN_DECD_TAXPERCENT="DECD_TAXPERCENT";
public static string COLUMN_DECD_BASEAMOUNT="DECD_BASEAMOUNT";
public static string COLUMN_DECD_EITAXPERCENT="DECD_EITAXPERCENT";
public static string COLUMN_DECD_REDUCEPERCENT="DECD_REDUCEPERCENT";
public static string COLUMN_PIT_AUTOID="PIT_AUTOID";
public static string COLUMN_WH_AUTOID="WH_AUTOID";
public static string COLUMN_CP_AUTOID="CP_AUTOID";
public static string COLUMN_COT_DOCUMENTID="COT_DOCUMENTID";
public static string COLUMN_DECD_NOTE="DECD_NOTE";
public static string COLUMN_PIT_ITEMNAME="PIT_ITEMNAME";
public static string COLUMN_UOM_AUTOID="UOM_AUTOID";
public static string COLUMN_ITG_AUTOID="ITG_AUTOID";
public static string COLUMN_TR_AUTOID="TR_AUTOID";
public static string COLUMN_PRJ_AUTOID="PRJ_AUTOID";
public static string COLUMN_ITT_AUTOID="ITT_AUTOID";
public static string COLUMN_PK_AUTOID="PK_AUTOID";
public static string COLUMN_PIT_ITEMNO="PIT_ITEMNO";

public static string TABLE_NAME ="DECLARATIONDETAIL";

public Nullable<Int64> DECD_AUTOID
	{	get
		{
			return ConvertToInt64(_dataRow[COLUMN_DECD_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_DECD_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<int> COT_DOCUMENTID
	{	get
		{
			return ConvertToInt32(_dataRow[COLUMN_COT_DOCUMENTID]);
		}
	set
		{
			_dataRow[COLUMN_COT_DOCUMENTID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<int> PIT_AUTOID
	{	get
		{
			return ConvertToInt32(_dataRow[COLUMN_PIT_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_PIT_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<Int16> ITG_AUTOID
	{	get
		{
			return ConvertToInt16(_dataRow[COLUMN_ITG_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_ITG_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<Int16> UOM_AUTOID
	{	get
		{
			return ConvertToInt16(_dataRow[COLUMN_UOM_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_UOM_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<Int16> TR_AUTOID
	{	get
		{
			return ConvertToInt16(_dataRow[COLUMN_TR_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_TR_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<Int16> PK_AUTOID
	{	get
		{
			return ConvertToInt16(_dataRow[COLUMN_PK_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_PK_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<int> CP_AUTOID
	{	get
		{
			return ConvertToInt32(_dataRow[COLUMN_CP_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_CP_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<Int16> ITT_AUTOID
	{	get
		{
			return ConvertToInt16(_dataRow[COLUMN_ITT_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_ITT_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<int> WH_AUTOID
	{	get
		{
			return ConvertToInt32(_dataRow[COLUMN_WH_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_WH_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<Int16> PRJ_AUTOID
	{	get
		{
			return ConvertToInt16(_dataRow[COLUMN_PRJ_AUTOID]);
		}
	set
		{
			_dataRow[COLUMN_PRJ_AUTOID] = GetSafeObjectValue(value, -1);
		}
		}
public Nullable<Int64> DEC_DOCUMENTID
	{	get
		{
			return ConvertToInt64(_dataRow[COLUMN_DEC_DOCUMENTID]);
		}
	set
		{
			_dataRow[COLUMN_DEC_DOCUMENTID] = GetSafeObjectValue(value, -1);
		}
		}
public String PIT_ITEMNO
	{	get
		{
			return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_PIT_ITEMNO], null));
		}
	set
		{
			_dataRow[COLUMN_PIT_ITEMNO] = Convert.ToString(GetSafeObjectValue(value, null));
		}
		}
public String PIT_ITEMNAME
	{	get
		{
			return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_PIT_ITEMNAME], null));
		}
	set
		{
			_dataRow[COLUMN_PIT_ITEMNAME] = Convert.ToString(GetSafeObjectValue(value, null));
		}
		}
public Decimal PIT_UNITPRICE
	{	get
		{
			 return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_PIT_UNITPRICE], -1));
		}
	set
		{
			_dataRow[COLUMN_PIT_UNITPRICE] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
		}
		}
public Decimal DECD_POIVQUANTITY
	{	get
		{
			 return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DECD_POIVQUANTITY], -1));
		}
	set
		{
			_dataRow[COLUMN_DECD_POIVQUANTITY] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
		}
		}
public Decimal DECD_QUANTITY
	{	get
		{
			 return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DECD_QUANTITY], -1));
		}
	set
		{
			_dataRow[COLUMN_DECD_QUANTITY] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
		}
		}
public Decimal DECD_AMOUNT
	{	get
		{
			 return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DECD_AMOUNT], -1));
		}
	set
		{
			_dataRow[COLUMN_DECD_AMOUNT] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
		}
		}
public Decimal DECD_EITAXPERCENT
	{	get
		{
			 return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DECD_EITAXPERCENT], -1));
		}
	set
		{
			_dataRow[COLUMN_DECD_EITAXPERCENT] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
		}
		}
public Decimal DECD_REDUCEPERCENT
	{	get
		{
			 return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DECD_REDUCEPERCENT], -1));
		}
	set
		{
			_dataRow[COLUMN_DECD_REDUCEPERCENT] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
		}
		}
public Decimal DECD_TAXPERCENT
	{	get
		{
			 return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DECD_TAXPERCENT], -1));
		}
	set
		{
			_dataRow[COLUMN_DECD_TAXPERCENT] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
		}
		}
public Decimal DECD_BASEAMOUNT
	{	get
		{
			 return Convert.ToDecimal(GetSafeObjectValue(_dataRow[COLUMN_DECD_BASEAMOUNT], -1));
		}
	set
		{
			_dataRow[COLUMN_DECD_BASEAMOUNT] = Convert.ToDecimal(GetSafeObjectValue(value, -1));
		}
		}
public String DECD_NOTE
	{	get
		{
			return Convert.ToString(GetSafeObjectValue(_dataRow[COLUMN_DECD_NOTE], null));
		}
	set
		{
			_dataRow[COLUMN_DECD_NOTE] = Convert.ToString(GetSafeObjectValue(value, null));
		}
		}
public Nullable<Int64> DOC_DOCUMENTID
	{	get
		{
			return ConvertToInt64(_dataRow[COLUMN_DOC_DOCUMENTID]);
		}
	set
		{
			_dataRow[COLUMN_DOC_DOCUMENTID] = GetSafeObjectValue(value, -1);
		}
		}
public DECLARATIONDETAIL(IDataReader RederObject) : base(RederObject, TABLE_NAME) { }
public DECLARATIONDETAIL(DataRow row) : base(row, TABLE_NAME) { }
public DECLARATIONDETAIL()
: base(TABLE_NAME, COLUMN_DECD_AUTOID, 
COLUMN_COT_DOCUMENTID, 
COLUMN_PIT_AUTOID, 
COLUMN_ITG_AUTOID, 
COLUMN_UOM_AUTOID, 
COLUMN_TR_AUTOID, 
COLUMN_PK_AUTOID, 
COLUMN_CP_AUTOID, 
COLUMN_ITT_AUTOID, 
COLUMN_WH_AUTOID, 
COLUMN_PRJ_AUTOID, 
COLUMN_DEC_DOCUMENTID, 
COLUMN_PIT_ITEMNO, 
COLUMN_PIT_ITEMNAME, 
COLUMN_PIT_UNITPRICE, 
COLUMN_DECD_POIVQUANTITY, 
COLUMN_DECD_QUANTITY, 
COLUMN_DECD_AMOUNT, 
COLUMN_DECD_EITAXPERCENT, 
COLUMN_DECD_REDUCEPERCENT, 
COLUMN_DECD_TAXPERCENT, 
COLUMN_DECD_BASEAMOUNT, 
COLUMN_DECD_NOTE, 
COLUMN_DOC_DOCUMENTID) { }
	}
}

