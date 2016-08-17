using UIKit;
using Realms;

namespace realmtest
{
    public class Test : RealmObject
    {
        public string Name { get; set; }
    }

    public class Application
    {
        static Transaction GetTransaction()
        {
            var realm = Realm.GetInstance();
            return realm.BeginWrite();
        }

        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            var transaction = GetTransaction();

            // Sleep two seconds, may need to adjust this value
            System.Threading.Thread.Sleep(2000);

            transaction.Dispose();

            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
