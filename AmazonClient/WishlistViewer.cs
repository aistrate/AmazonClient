using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AmazonClient.AmazonService;
using System.ServiceModel;

namespace AmazonClient
{
    public partial class WishlistViewer : Form
    {
        private const string accessKeyId = "AKIAIBXJMQV42YTDN4LA";
        private const string secretKey = "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";
        
        private const string customerId = "A2OERDJWDTFPHW";

        public WishlistViewer()
        {
            InitializeComponent();
        }

        public AWSECommerceServicePortTypeClient Client
        {
            get
            {
                if (client == null)
                {
                    BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
                    binding.MaxReceivedMessageSize = int.MaxValue;
                    binding.ReaderQuotas.MaxStringContentLength = int.MaxValue;
                    client = new AWSECommerceServicePortTypeClient(
                                    binding,
                                    new EndpointAddress("https://webservices.amazon.com/onca/soap?Service=AWSECommerceService"));
                    
                    // add authentication to the ECS client
                    client.ChannelFactory.Endpoint.Behaviors.Add(new AmazonSigningEndpointBehavior(accessKeyId, secretKey));
                }

                return client;
            }
        }
        private AWSECommerceServicePortTypeClient client;

        private void WishlistViewer_Load(object sender, EventArgs e)
        {
            try
            {
                //ListSearchRequest request = new ListSearchRequest();
                //request.ListType = ListSearchRequestListType.WishList;
                //request.Email = "adr_istrate@yahoo.com";
                //request.ResponseGroup = new string[] { "ListMinimum" };

                //ListSearch listSearch = new ListSearch();
                //listSearch.Request = new ListSearchRequest[] { request };
                //listSearch.AWSAccessKeyId = accessKeyId;

                //ListSearchResponse response = Client.ListSearch(listSearch);

                //List[] wishlists = response.Lists[0].List ?? new List[] { };

                //var results = wishlists.OrderBy(list => list.ListName)
                //                       .Select(list => new
                //                       {
                //                           list.ListId,
                //                           list.ListName
                //                       })
                //                       .ToList();

                //results.Insert(0, new { ListId = "", ListName = "" });

                //bsWishlists.DataSource = results;
                //cbWishlists.ValueMember = "ListId";
                //cbWishlists.DisplayMember = "ListName";


                List<KeyValuePair<string, string>> results = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("", ""),
                    new KeyValuePair<string, string>("1PVD58E39T15L", "Kindle-Accessories"),
                    new KeyValuePair<string, string>("33N1J1YX74ANF", "Kindle-Biography"),
                    new KeyValuePair<string, string>("18MYIV5BM9K32", "Kindle-Fiction"),
                    new KeyValuePair<string, string>("112OHTNEC04RH", "Kindle-History"),
                    new KeyValuePair<string, string>("1GK6TOK5KSG6", "Kindle-NonFiction"),
                    new KeyValuePair<string, string>("34M965M2F0OX2", "Kindle-Programming"),
                    new KeyValuePair<string, string>("1ZLEEHALKJBHU", "Kindle-Reference"),
                    new KeyValuePair<string, string>("1JQ5NKW1B1G50", "Kindle-ScienceHistory"),

                    new KeyValuePair<string, string>("1YM02JF1IRK49", "AlphaGeek4")

                    //new KeyValuePair<string, string>("2OP8548TSNB5S", "CS-Auxiliary"),
                    //new KeyValuePair<string, string>("2TLYGARP98S1D", "CS-FinishedReading"),
                    //new KeyValuePair<string, string>("1KSVUUX3UH9BE", "CS-HeavyButEssential"),
                    //new KeyValuePair<string, string>("1F4HSQS6BW026", "CS-Inspiration"),
                    //new KeyValuePair<string, string>("3ESHNUSKYMVIY", "CS-Other"),
                    //new KeyValuePair<string, string>("3VFBSLZC7GZKP", "CS-ReadingNow"),
                    //new KeyValuePair<string, string>("3CBTCLYF8SXV7", "CS-ReadingSoonOwned"),
                    //new KeyValuePair<string, string>("NK6KLSJ0IHM7", "CS-TastyToReadNext"),

                    //new KeyValuePair<string, string>("2BBRSYTN57I6A", "ToReadNext2010")
                };

                bsWishlists.DataSource = results.OrderBy(pair => pair.Value);
                cbWishlists.ValueMember = "Key";
                cbWishlists.DisplayMember = "Value";
            }
            catch (Exception ex)
            {
                txtErrorMessages.Text = getErrorMessages(ex);
            }
        }

        private void btnGetCustomerId_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerContentSearchRequest request = new CustomerContentSearchRequest();
                request.Email = "adr_istrate@yahoo.com";
                request.ResponseGroup = new string[] { "CustomerInfo" };

                CustomerContentSearch customerContentSearch = new CustomerContentSearch();
                customerContentSearch.Request = new CustomerContentSearchRequest[] { request };
                customerContentSearch.AWSAccessKeyId = accessKeyId;

                CustomerContentSearchResponse response = Client.CustomerContentSearch(customerContentSearch);

                var customers = response.Customers[0].Customer;
                if (customers.Length > 0)
                    MessageBox.Show(customers[0].CustomerId, "Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //CustomerContentLookupRequest request = new CustomerContentLookupRequest();
                //request.CustomerId = customerId;
                //request.ResponseGroup = new string[] { "CustomerInfo" };

                //CustomerContentLookup customerContentLookup = new CustomerContentLookup();
                //customerContentLookup.Request = new CustomerContentLookupRequest[] { request };
                //customerContentLookup.AWSAccessKeyId = accessKeyId;

                //CustomerContentLookupResponse response = Client.CustomerContentLookup(customerContentLookup);

                //var customers = response.Customers[0].Customer;
            }
            catch (Exception ex)
            {
                txtErrorMessages.Text = getErrorMessages(ex);
            }
        }

        private void cbWishlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtErrorMessages.Text = "Retrieving data...";
            txtErrorMessages.Refresh();

            try
            {
                if (cbWishlists.SelectedIndex > 0)
                {
                    ListLookupRequest request = new ListLookupRequest();
                    request.ListType = ListLookupRequestListType.WishList;
                    request.ListTypeSpecified = true;
                    request.ListId = (string)cbWishlists.SelectedValue;
                    request.ResponseGroup = new string[] { "Large" };

                    ListLookup listLookup = new ListLookup();
                    listLookup.Request = new ListLookupRequest[] { request };
                    listLookup.AWSAccessKeyId = accessKeyId;

                    List<ListItem> listItems = new List<ListItem>();

                    for (int page = 1; true; page++)
                    {
                        request.ProductPage = page.ToString();
                        ListLookupResponse response = Client.ListLookup(listLookup);

                        if (response.Lists[0].List == null)
                            break;

                        listItems.AddRange(response.Lists[0].List[0]
                                                   .ListItem.Where(item => item.Item != null));
                    }

                    var results = listItems.Select(item => new
                                           {
                                               item.Item.ItemAttributes.Title,
                                               Author = item.Item.ItemAttributes.Author != null
                                                            ? string.Join(", ", item.Item.ItemAttributes.Author)
                                                            : "",
                                               SalesRank = int.Parse(item.Item.SalesRank ?? "0"),
                                               Price = toString(item.Item.ItemAttributes.ListPrice),
                                               Pages = int.Parse(item.Item.ItemAttributes.NumberOfPages ?? "0"),
                                               TotalReviews = item.Item.CustomerReviews != null 
                                                                ? int.Parse(item.Item.CustomerReviews.TotalReviews ?? "0") : 0,
                                               AverageRating = item.Item.CustomerReviews != null
                                                                ? item.Item.CustomerReviews.AverageRating : 0m,
                                               item.Item.ItemAttributes.PublicationDate,
                                               item.Item.ItemAttributes.Publisher,
                                               item.Item.ItemAttributes.Binding,
                                               item.Item.ItemAttributes.Edition,
                                               item.Item.DetailPageURL
                                           });

                    lblItemCount.Text = string.Format("({0} items)", results.Count());

                    bsResults.DataSource = results.ToDataSet();
                    bsResults.DataMember = "Results";
                    gvResults.Sort(gvResults.Columns[0], ListSortDirection.Ascending);
                    
                    txtErrorMessages.Text = "Data successfully retrieved.";
                    gvResults.Focus();

                    return;
                }
            }
            catch (Exception ex)
            {
                txtErrorMessages.Text = getErrorMessages(ex);
                return;
            }

            txtErrorMessages.Text = "No data.";
            lblItemCount.Text = "";
            bsResults.DataSource = null;
        }

        private decimal toString(Price price)
        {
            if (price != null)
            {
                return ((decimal)int.Parse(price.Amount)) / 100m;
            }
            else
                return 0m;
        }

        private string getErrorMessages(Exception ex)
        {
            return ex.Message + (ex.InnerException != null ? "\r\n" + getErrorMessages(ex.InnerException) : "");
        }

        private void gvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    DataRow row = ((DataRowView)gvResults.Rows[e.RowIndex].DataBoundItem).Row;
                    string url = (string)row["DetailPageURL"];

                    System.Diagnostics.Process.Start(url);
                }
            }
            catch (Exception ex)
            {
                txtErrorMessages.Text = getErrorMessages(ex);
            }
        }
    }
}
