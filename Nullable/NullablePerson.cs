using System;

namespace CSHARP.Nullable
{
    //Example
    /*
        Address contact = user.ContactAddress ?? order.ShippingAddress ?? user.BillingAddress
    */
    public class NullablePerson
    {
        public NullablePerson(string name, DateTime birth, DateTime? death){
            this.name = name;
            this.birth = birth;
            this.death = death;
        }
        DateTime birth;
        DateTime? death;
        string name;
        public TimeSpan Age{
            get{

                return (death ?? DateTime.Now) - birth;

                //Same as above
                /*if(death == null){
                    return DateTime.Now - birth;
                }else{
                    return death.Value - birth;
                }*/
            }
        }
    }
}