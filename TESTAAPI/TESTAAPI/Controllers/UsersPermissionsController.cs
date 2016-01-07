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
    public class UsersPermissionsController : ApiController
    {
        private MedisysEntities2 db = new MedisysEntities2();

        // GET: api/UsersPermissions
        public IQueryable<UsersPermissions> GetUsersPermissions()
        {
            return db.UsersPermissions;
        }

        // GET: api/UsersPermissions/5
        [ResponseType(typeof(UsersPermissions))]
        public IHttpActionResult GetUsersPermissions(int id)
        {
            UsersPermissions usersPermissions = db.UsersPermissions.Find(id);
            if (usersPermissions == null)
            {
                return NotFound();
            }

            return Ok(usersPermissions);
        }

        // PUT: api/UsersPermissions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsersPermissions(int id, UsersPermissions usersPermissions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usersPermissions.Broj)
            {
                return BadRequest();
            }

            db.Entry(usersPermissions).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersPermissionsExists(id))
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

        // POST: api/UsersPermissions
        [ResponseType(typeof(UsersPermissions))]
        public IHttpActionResult PostUsersPermissions(UsersPermissions usersPermissions)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UsersPermissions.Add(usersPermissions);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = usersPermissions.Broj }, usersPermissions);
        }

        // DELETE: api/UsersPermissions/5
        [ResponseType(typeof(UsersPermissions))]
        public IHttpActionResult DeleteUsersPermissions(int id)
        {
            UsersPermissions usersPermissions = db.UsersPermissions.Find(id);
            if (usersPermissions == null)
            {
                return NotFound();
            }

            db.UsersPermissions.Remove(usersPermissions);
            db.SaveChanges();

            return Ok(usersPermissions);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersPermissionsExists(int id)
        {
            return db.UsersPermissions.Count(e => e.Broj == id) > 0;
        }
    }
}