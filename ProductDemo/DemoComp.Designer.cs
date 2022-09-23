namespace ProductDemo
{
    partial class DemoComp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoComp));
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.stockDataSet11 = new ProductDemo.StockDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet11)).BeginInit();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=DisConnected;User ID=sa;Password=Shivansh@123";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT pid, pname, price, AvlQty\r\nFROM     Product";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Product] ([pid], [pname], [price], [AvlQty]) VALUES (@pid, @pname, @" +
    "price, @AvlQty);\r\nSELECT pid, pname, price, AvlQty FROM Product WHERE (pid = @pi" +
    "d)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pid", System.Data.SqlDbType.Int, 0, "pid"),
            new System.Data.SqlClient.SqlParameter("@pname", System.Data.SqlDbType.VarChar, 0, "pname"),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Float, 0, "price"),
            new System.Data.SqlClient.SqlParameter("@AvlQty", System.Data.SqlDbType.Int, 0, "AvlQty")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pid", System.Data.SqlDbType.Int, 0, "pid"),
            new System.Data.SqlClient.SqlParameter("@pname", System.Data.SqlDbType.VarChar, 0, "pname"),
            new System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Float, 0, "price"),
            new System.Data.SqlClient.SqlParameter("@AvlQty", System.Data.SqlDbType.Int, 0, "AvlQty"),
            new System.Data.SqlClient.SqlParameter("@Original_pid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AvlQty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AvlQty", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Product] WHERE (([pid] = @Original_pid) AND ([pname] = @Original_pna" +
    "me) AND ([price] = @Original_price) AND ([AvlQty] = @Original_AvlQty))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_pid", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pid", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "price", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AvlQty", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AvlQty", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Product", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pid", "pid"),
                        new System.Data.Common.DataColumnMapping("pname", "pname"),
                        new System.Data.Common.DataColumnMapping("price", "price"),
                        new System.Data.Common.DataColumnMapping("AvlQty", "AvlQty")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            this.sqlDataAdapter1.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(this.sqlDataAdapter1_RowUpdated);
            // 
            // stockDataSet11
            // 
            this.stockDataSet11.DataSetName = "StockDataSet1";
            this.stockDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            ((System.ComponentModel.ISupportInitialize)(this.stockDataSet11)).EndInit();

        }

        #endregion
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        public System.Data.SqlClient.SqlConnection sqlConnection1;
        public System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        public StockDataSet1 stockDataSet11;
    }
}
