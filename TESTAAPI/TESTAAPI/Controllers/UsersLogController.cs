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
    public class UsersLogController : ApiController
    {
        private MedisysEntities1 db = new MedisysEntities1();

        // GET: api/UsersLogs
        public IQueryable<UsersLog> GetUsersLog()
        {
            return db.UsersLog;
        }

        // GET: api/UsersLogs/5
        [ResponseType(typeof(UsersLog))]
        public IHttpActionResult GetUsersLog(int id)
        {
            UsersLog usersLog = db.UsersLog.Find(id);
            if (usersLog == null)
            {
                return NotFound();
            }

            return Ok(usersLog);
        }

        // PUT: api/UsersLogs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsersLog(int id, UsersLog usersLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usersLog.LogID)
            {
                return BadRequest();
            }

            db.Entry(usersLog).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersLogExists(id))
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

        // POST: api/UsersLogs
        [ResponseType(typeof(UsersLog))]
        public IHttpActionResult PostUsersLog(UsersLog usersLog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.UsersLog.Add(usersLog);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = usersLog.LogID }, usersLog);
        }

        // DELETE: api/UsersLogs/5
        [ResponseType(typeof(UsersLog))]
        public IHttpActionResult DeleteUsersLog(int id)
        {
            UsersLog usersLog = db.UsersLog.Find(id);
            if (usersLog == null)
            {
                return NotFound();
            }

            db.UsersLog.Remove(usersLog);
            db.SaveChanges();

            return Ok(usersLog);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersLogExists(int id)
        {
            return db.UsersLog.Count(e => e.LogID == id) > 0;
        }
    }
}