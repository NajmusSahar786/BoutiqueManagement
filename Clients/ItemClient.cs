using BoutiqueManagement.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoutiqueManagement.Clients
{
    public class ItemClient
    {
        private IItemService _service;
        public ItemClient(IItemService service)
        {
            this._service = service;
        }
        public void ServeMethod()
        {
            this._service.Serve();
        }
    }
}