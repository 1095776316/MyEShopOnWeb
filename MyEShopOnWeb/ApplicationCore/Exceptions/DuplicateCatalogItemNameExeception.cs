using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Exceptions
{
    public class DuplicateCatalogItemNameExeception : Exception
    {
        public DuplicateCatalogItemNameExeception(string message, int duplicateItemId) : base(message)
        {
            DuplicateItemId = duplicateItemId;
        }
        public int DuplicateItemId { get; }
    }
}
