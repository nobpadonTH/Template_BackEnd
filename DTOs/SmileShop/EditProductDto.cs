namespace NetCoreAPI_Template_v3_with_auth.DTOs.SmileShop
{
    public class EditProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductGroupId { get; set; }
    }
}