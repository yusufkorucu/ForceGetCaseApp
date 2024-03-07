namespace ForceGet.Domain.Dtos.Response
{
    public class DataTableResponse<T> where T : new()
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get { return this.recordsTotal; } }
        public List<T> data { get; set; }
        public List<string> columns { get; set; }

        public DataTableResponse()
        {
            data = new List<T>();
        }
    }



}
