using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class MyClass
{
    public static int Counter;
    
    //shorcut: ctor
    public MyClass()
    {
        Counter++;
    }

 


    /*
 https://msdn.microsoft.com/en-us/library/66x5fx1b.aspx
The destructor implicitly calls Finalize on the base class of the object. Therefore, the previous destructor code is implicitly translated to the following code:
protected override void Finalize()
{
try
{
    // Cleanup statements...
}
finally
{
    base.Finalize();
}
}
 */
     ~MyClass()   // destructor
    {
        Counter--;
    }




}
