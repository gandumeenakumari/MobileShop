using MobileShop.Data;
namespace MobileShop.Core
{
    public class Bll
    {
        private Data.MobileDbContext dal;
        public Bll()
        {
            dal = new Data.MobileDbContext();
        }
        public List<Mobile> GetMobiles()
        {
            List<Mobile> mobile = dal.GetMobiles();
            return dal.GetMobiles();
        }
        public void PostMobile(Mobile mobile)
        {
            dal.PostMobile(mobile);
        }
        public void DeleteMobile(int MobileId)
        {
            var db = new MobileDbContext();
            Mobile mobile = new Mobile();
            mobile = db.Mobiles.FirstOrDefault(x => x.MobileId == MobileId);
            if (mobile == null)
                throw new Exception("Not Found");
            dal.DeleteMobile(MobileId);
        }


    }
}
































































//using MobileShop.Data;
//namespace MobileShop.Core
//{
//    public class Bll
//    {
//        private Data.MobileDbContext dal;
//        public Bll()
//        {
//            dal = new Data.MobileDbContext();
//        }
//        public List<Mobile>GetMobiles()
//        {
//            List<Mobile> mobile = dal.GetMobiles();
//            return dal.GetMobiles();
//        }
//        public void PostMobile(Mobile mobile)
//        {
//            dal.PostMobile(mobile);
//        }
//        public void DeleteMobile(int MobileId)
//        {
//            var db = new MobileDbContext();
//            Mobile mobile = new Mobile();
//            mobile = db.Mobiles.FirstOrDefault(x => x.MobileId == MobileId);
//            if (mobile == null)
//                throw new Exception("Not Found");
//            dal.DeleteMobile(MobileId);
//        }


//    }
//}
