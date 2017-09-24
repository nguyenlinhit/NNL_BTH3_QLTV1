using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BTH3
{
    class XL_BANG : DataTable
    {
        private static String chuoi_lien_ket;

        public static String Chuoi_lien_ket
        {
            get { return XL_BANG.chuoi_lien_ket; }
            set { XL_BANG.chuoi_lien_ket = value; }
        }
        private SqlDataAdapter mBo_doc_ghi;

        public SqlDataAdapter MBo_doc_ghi
        {
            get { return mBo_doc_ghi; }
            set { mBo_doc_ghi = value; }
        }
        private SqlConnection mKet_noi;

        public SqlConnection MKet_noi
        {
            get { return mKet_noi; }
            set { mKet_noi = value; }
        }
        private String chuoi_csdl;

        public String Chuoi_csdl
        {
            get { return chuoi_csdl; }
            set { chuoi_csdl = value; }
        }
        private String mChuoi_SQL;

        public String MChuoi_SQL
        {
            get { return mChuoi_SQL; }
            set { mChuoi_SQL = value; }
        }
        private String mTen_Bang;

        public String MTen_Bang
        {
            get { return mTen_Bang; }
            set { mTen_Bang = value; }
        }


        public XL_BANG() : base() { }

        public XL_BANG(String pTen_Bang)
        {
            mTen_Bang = pTen_Bang;
            Doc_bang();
        }

        public XL_BANG(String pTen_Bang, String pChuoi_SQL)
        {
            mTen_Bang = pTen_Bang;
            mChuoi_SQL = pChuoi_SQL;
            Doc_bang();
        }
        private void Doc_bang()
        {
            if (mChuoi_SQL == null)
            {
                mChuoi_SQL = "select * from " + mTen_Bang;
            }
            if (mKet_noi == null)
            {
                mKet_noi = new SqlConnection(chuoi_lien_ket);
            }

            try
            {
                mBo_doc_ghi = new SqlDataAdapter(mChuoi_SQL, mKet_noi);
                mBo_doc_ghi.FillSchema(this, SchemaType.Mapped);
                //mBo_doc_ghi.RowUpdated += new SqlRowUpdatedEventHandler()
            }
            catch (SqlException e)
            {
                
            }
        }

    }
}
