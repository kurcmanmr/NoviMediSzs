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
using TESTAAPI.Models;

namespace TESTAAPI.Controllers
{
    public class UsersCurrentsController : ApiController
    {
        private MedisysEntities2 db = new MedisysEntities2();

        // GET: api/UsersCurrents
        public IQueryable<UsersCurrent> GetUsersCurrent()
        {
            return db.UsersCurrent;
        }

        // GET: api/UsersCurrents/5
        [ResponseType(typeof(UsersCurrent))]
        public IHttpActionResult GetUsersCurrent(int id)
        {
            UsersCurrent usersCurrent = db.UsersCurrent.Find(id);
            if (usersCurrent == null)
            {
                return NotFound();
            }

            return Ok(usersCurrent);
        }

        // PUT: api/UsersCurrents/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsersCurrent(int id, UsersCurrent usersCurrent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usersCurrent.ID)
            {
                return BadRequest();
            }

            db.Entry(usersCurrent).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersCurrentExists(id))
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

        // POST: api/UsersCurrents
        [ResponseType(typeof(UsersCurrent))]
        public IHttpActionResult PostUsersCurrent(UsersCurrent usersCurrent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UsersCurrent.Add(usersCurrent);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UsersCurrentExists(usersCurrent.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = usersCurrent.ID }, usersCurrent);
        }

        // DELETE: api/UsersCurrents/5
        [ResponseType(typeof(UsersCurrent))]
        public IHttpActionResult DeleteUsersCurrent(int id)
        {
            UsersCurrent usersCurrent = db.UsersCurrent.Find(id);
            if (usersCurrent == null)
            {
                return NotFound();
            }

            db.UsersCurrent.Remove(usersCurrent);
            db.SaveChanges();

            return Ok(usersCurrent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersCurrentExists(int id)
        {
            return db.UsersCurrent.Count(e => e.ID == id) > 0;
        }
    }
}