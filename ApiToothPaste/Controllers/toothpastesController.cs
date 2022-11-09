using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiToothPaste.Models;

namespace ApiToothPaste.Controllers
{
    public class toothpastesController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/toothpastes
        [ResponseType(typeof(List<ModelToothPaste>))]
        public IHttpActionResult Gettoothpaste()
        {
            return Ok(db.toothpaste.ToList().ConvertAll(x => new ModelToothPaste(x)));
        }

        // GET: api/toothpastes/5
        [ResponseType(typeof(toothpaste))]
        public IHttpActionResult Gettoothpaste(int id)
        {
            toothpaste toothpaste = db.toothpaste.Find(id);
            if (toothpaste == null)
            {
                return NotFound();
            }

            return Ok(toothpaste);
        }

        // PUT: api/toothpastes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttoothpaste(int id, toothpaste toothpaste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != toothpaste.id_toothpaste)
            {
                return BadRequest();
            }

            db.Entry(toothpaste).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!toothpasteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/toothpastes
        [ResponseType(typeof(toothpaste))]
        public IHttpActionResult Posttoothpaste(toothpaste toothpaste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.toothpaste.Add(toothpaste);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = toothpaste.id_toothpaste }, toothpaste);
        }

        // DELETE: api/toothpastes/5
        [ResponseType(typeof(toothpaste))]
        public IHttpActionResult Deletetoothpaste(int id)
        {
            toothpaste toothpaste = db.toothpaste.Find(id);
            if (toothpaste == null)
            {
                return NotFound();
            }

            db.toothpaste.Remove(toothpaste);
            db.SaveChanges();

            return Ok(toothpaste);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool toothpasteExists(int id)
        {
            return db.toothpaste.Count(e => e.id_toothpaste == id) > 0;
        }
    }
}