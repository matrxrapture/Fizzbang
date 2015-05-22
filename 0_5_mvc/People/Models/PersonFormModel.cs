using System.ComponentModel;
                   using System.Web.Mvc;
namespace People.Models
{
    public class PersonFormModel
    {
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string Surname { get; set; }

        [DisplayName("Address line 1")]
        public string AddressLine1 { get; set; }

        [DisplayName("Address line 2")]
        public string AddressLine2 { get; set; }

        [DisplayName("Suburb")]
        public string AddressSuburb { get; set; }

        [DisplayName("Town/City")]
        public string AddressTownCity { get; set; }

        [DisplayName("Province")]
        public string AddressProvince { get; set; }

        [DisplayName("Postcode")]
        public string AddressPostCode { get; set; }

        [DisplayName("ID Number")]
        public string IDNumber { get; set; }

        public SelectList province { get; set; }
    }
}