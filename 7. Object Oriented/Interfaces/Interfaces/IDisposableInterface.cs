using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    using Microsoft.Win32.SafeHandles;
    using System;
    using System.Runtime.InteropServices;

    //https://msdn.microsoft.com/en-us/library/system.idisposable(v=vs.110).aspx



    class BaseClassIDisposable : IDisposable
    {
        // Flag: Has Dispose already been called? 
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers. 
        public void Dispose()
        {
            Dispose(true);
            //If the IDisposable.Dispose method is called, it frees resources of the object. 
            //This makes finalization unnecessary. IDisposable.Dispose should call GC.SuppressFinalize 
            //so the garbage collector does not call the finalizer of the object.
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern. 
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here. 
                //
            }

            // Free any unmanaged objects here. 
            //
            disposed = true;
        }

        ~BaseClassIDisposable()
        {
            Dispose(false);
        }
    }
}
