namespace ForceGet.Domain.Dtos.Request
{
  
    public class DataTableRequestDto
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }

        public DataTableRequestColumnOrder Order { get; set; }
        public List<NameValuePair> Filter { get; set; }

        public DataTableRequestDto()
        {
            Filter = new List<NameValuePair>();
        }
    }

    public class DataTableRequestColumnOrder
    {
        private string _column;

        public string Column
        {
            get
            {
                if (this._column != null && this._column.EndsWith("Text"))
                    return this._column.Replace("Text", string.Empty);

                return this._column;
            }
            set
            {
                this._column = value;
            }
        }
        public string Dir { get; set; }
    }

    public class NameValuePair
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
