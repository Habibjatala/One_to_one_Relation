using Microsoft.EntityFrameworkCore;

namespace One_to_one_Relation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var db = new ContextDB())
            {
                db.Database.EnsureCreated();
                var users = new List<User>();

                //// INSERT NEW DATA 
                ///

                for (int i = 1; i <= 1; i++)
                {
                    Console.WriteLine("Enter the User name : " + i);
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter the User Email : " + i);
                    var email = Console.ReadLine();
                    Console.WriteLine("Enter the User Address : " + i);
                    var address = Console.ReadLine();


                   // users.Add(new User { FullName = name, Profile = new UserProfile { Email = email, Address = address } });

                }


                db.Users.AddRange(users);
                db.SaveChanges();

                /////////////////////////////////////////////////////////////////////////

                ///// UPDATE THE USER DETAIL

                //Console.WriteLine("Enter the User name that you want to update:");
                //var update_name = Console.ReadLine();
                //var updateuser = db.Users.Include(p=> p.Profile).FirstOrDefault(u=> u.FullName == update_name);

                //if(updateuser == null)
                //{
                //    Console.WriteLine("Enter the Correct name For Update DAta ");

                //}
                //else
                //{
                //    Console.WriteLine("Enter the Updated Name of User :");
                //   var update_user = Console.ReadLine();
                //  updateuser.FullName = update_user;

                //    Console.WriteLine("If you want to update the UserProfile Press Y/N :");
                //   char value = Convert.ToChar(Console.ReadLine());

                //    switch (value)
                //    {
                //        case 'y':
                //            {
                //                Console.WriteLine("Update the User Email : " );
                //                  var email = Console.ReadLine();
                //              Console.WriteLine("Update the User Address : ");
                //                 var address = Console.ReadLine();

                //                updateuser.Profile.Email = email;
                //                updateuser.Profile.Address = address;
                //                break;
                //            }
                //        default:
                //            {
                //                Console.WriteLine("Only User name is Updated");
                //                break;
                //            }

                //    }

                //    db.SaveChanges();
                //}


                /////////////////////////////////////////////////////////////////////////

                /// Delete Data
                /// 
                //Console.WriteLine("Enter the User ID that you want to delete:");
                //var id = Convert.ToInt32(Console.ReadLine());

                //var deleteUser = db.Users.Include(u => u.Profile).FirstOrDefault(u => u.UserId == id);

                //if (deleteUser == null)
                //{
                //    Console.WriteLine("User not found for deletion.");
                //}
                //else
                //{
                //    Console.WriteLine("Deleted User: " + deleteUser.FullName);

                //    if (deleteUser.Profile != null)
                //    {
                //        Console.WriteLine("Deleted User Profile: " + deleteUser.Profile.Email);
                //        db.Profiles.Remove(deleteUser.Profile);
                //    }

                //    db.Users.Remove(deleteUser);
                //    db.SaveChanges();
                //}

                ////////////////////////////////////////////////////////////
                ///
               //////   READ USER DATA
               // var data = db.Users.Include(p => p.Profile).ToList();

                //foreach(var item in data)
                //{
                //    Console.WriteLine("\n\nUser Name: " + item.FullName);
                //    Console.WriteLine("Email: " + item.Profile.Email);
                //    Console.WriteLine("Address: " + item.Profile.Address);
                //}

            }
        }
    }
}