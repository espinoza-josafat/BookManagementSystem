﻿using System;

namespace BookManagementSystem.Infraestructure
{
    public class Disposable : IDisposable
    {
        bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }

            isDisposed = true;
        }

        // Override this to dispose custom objects
        protected virtual void DisposeCore()
        {
        }
    }
}