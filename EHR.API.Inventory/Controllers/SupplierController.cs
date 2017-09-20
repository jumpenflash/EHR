using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EHR.DAL.Entities;
using EHR.DAL.Repositories.Interfaces;
using System.IO;
using EHR.BLL.UnitOfWork;
using System.Text;
using EHR.BLL.UnitOfWork.Interfaces;
using EHR.DAL.Inventory.Entities;
using EHR.BLL.Inventory.UnitOfWork.Interfaces;

namespace EHR.API.Inventory.Controllers
{
    [Produces("application/json")]
    [Route("api/Suppliers")]
    public class SuppliersController : Controller
    {
        private readonly IInventoryUnitOfWork _unitOfWork;

        public SuppliersController(IInventoryUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Suppliers
        [HttpGet]
        public IEnumerable<Supplier> GetSuppliers()
        {
            return _unitOfWork.Suppliers.GetAll();
        }

        // GET: api/Suppliers/5
        [HttpGet("{id}")]
        public IActionResult GetSupplier([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplier = _unitOfWork.Suppliers.Get(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return Ok(supplier);
        }

        // PUT: api/Suppliers/5
        [HttpPut("{id}")]
        public IActionResult PutSupplier([FromRoute] int id, [FromBody] Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != supplier.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Suppliers.Update(supplier);
            _unitOfWork.Complete();

            return NoContent();
        }

        //POST: api/Suppliers
        [HttpPost]
        public IActionResult PostSupplier([FromBody] Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _unitOfWork.Suppliers.Add(supplier);
            _unitOfWork.Complete();

            return CreatedAtAction("GetSupplier", new { id = supplier.Id }, supplier);
        }

        // DELETE: api/Suppliers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSupplier([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplier = _unitOfWork.Suppliers.Get(id);
            if (supplier == null)
            {
                return NotFound();
            }

            _unitOfWork.Suppliers.Remove(supplier);
            _unitOfWork.Complete();

            return Ok(supplier);
        }

        private bool SupplierExists(int id)
        {
            return _unitOfWork.Suppliers.Get(id) != null;
        }
    }
}