

namespace automation1.Test
{
    [TestFixture]
    public class TM_test : ComonDriver
    {
       
        [Test, Order(1), Description("Check if user is able to create a new record with valid data")]
        public void CreateTM_Test()
        {
            //import Homepage here
            Homepage homepageobj = new Homepage();
            homepageobj.gotoTMpage(driver);
            TMpage tmpageobj = new TMpage();
            tmpageobj.createTM(driver);

        }
        [Test, Order(2), Description("Check if user is able to edit record with valid data")]
        public void EditTM_Test()
        {
            //import Homepage here
            Homepage homepageobj = new Homepage();
            homepageobj.gotoTMpage(driver);
            TMpage tmpageobj = new TMpage();
            tmpageobj.editTM(driver);
        }
        [Test, Order(3), Description("Check if user is able to delete data")]
        public void DeleteTM_Test()
        {
            //import Homepage here
            Homepage homepageobj = new Homepage();
            homepageobj.gotoTMpage(driver);
            TMpage tmpageobj = new TMpage();
            tmpageobj.deleteTM(driver);
        }
      

      




    }
}



