namespace SignalR.Web.UI.Dtos.ContactDtos
{
    public class GetByIDContactDto
    {
        public int ContactID { get; set; }

        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string FooterDescription { get; set; }
    }
}
