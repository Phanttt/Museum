using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Data.ObjsForReceiving;
using Museum.Models;
using Museum.Models.Tabs.Receiving;
using Museum.Models.Users;

namespace Museum.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceivingController : Controller
    {
        private MuseumContext context;

        public ReceivingController(MuseumContext context)
        {
            this.context = context;
        }
        [HttpGet("GetStructures")]
        public async Task<ActionResult<IEnumerable<Structure>>> GetStructures()
        {
            List<Structure> data = await context.Structures.ToListAsync();
            return data;
        }
        [HttpGet("GetPeoples")]
        public async Task<ActionResult<IEnumerable<People>>> GetPeoples()
        {
            List<People> data = await context.Peoples.ToListAsync();
            return data;
        }
        [HttpGet("GetEvents")]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            List<Event> data = await context.Events.ToListAsync();
            return data;
        }
        [HttpGet("GetStatuses")]
        public async Task<ActionResult<IEnumerable<Status>>> GetStatuses()
        {
            List<Status> data = await context.Statuses.ToListAsync();
            return data;
        }
        [HttpGet("GetOwners")]
        public async Task<ActionResult<IEnumerable<Owner>>> GetOwners()
        {
            List<Owner> data = await context.Owners.ToListAsync();
            return data;
        }
        [HttpGet("GetProviders")]
        public async Task<ActionResult<IEnumerable<Provider>>> GetProviders()
        {
            List<Provider> data = await context.Providers.ToListAsync();
            return data;
        }
        [HttpGet("GetReceiveWays")]
        public async Task<ActionResult<IEnumerable<ReceiveWay>>> GetReceiveWays()
        {
            List<ReceiveWay> data = await context.ReceiveWays.ToListAsync();
            return data;
        }
        [HttpGet("GetReceivers")]
        public async Task<ActionResult<IEnumerable<User>>> GetReceivers()
        {
            List<User> data = await context.Users.ToListAsync();
            return data;
        }
        [HttpGet("GetPurposes")]
        public async Task<ActionResult<IEnumerable<Purpose>>> GetPurposes()
        {
            List<Purpose> data = await context.Purposes.ToListAsync();
            return data;
        }
        [HttpGet("GetCurrencies")]
        public async Task<ActionResult<IEnumerable<Currency>>> GetCurrencies()
        {
            List<Currency> data = await context.Currencies.ToListAsync();
            return data;
        }
        [HttpGet("GetProducers")]
        public async Task<ActionResult<IEnumerable<Producer>>> GetProducers()
        {
            List<Producer> data = await context.Producers.ToListAsync();
            return data;
        }
        [HttpGet("GetEventTypes")]
        public async Task<ActionResult<IEnumerable<EventType>>> GetEventTypes()
        {
            List<EventType> data = await context.EventTypes.ToListAsync();
            return data;
        }
        [HttpPost("AddStructure")]
        public async Task<ActionResult<Structure>> AddStructure(Structure structure)
        {
            await context.Structures.AddAsync(structure);
            await context.SaveChangesAsync();
            return structure;
        }
        [HttpPost("AddPeople")]
        public async Task<ActionResult<People>> AddPeople(People people)
        {
            await context.Peoples.AddAsync(people);
            await context.SaveChangesAsync();
            return people;
        }
        [HttpPost("AddOwner")]
        public async Task<ActionResult<Owner>> AddOwner(Owner owner)
        {
            await context.Owners.AddAsync(owner);
            await context.SaveChangesAsync();
            return owner;
        }
        [HttpPost("AddProvider")]
        public async Task<ActionResult<Provider>> AddProvider(Provider provider)
        {
            await context.Providers.AddAsync(provider);
            await context.SaveChangesAsync();
            return provider;
        }
        [HttpPost("AddEvent")]
        public async Task<ActionResult<int>> AddEvent(Event ev)
        {
            context.Entry(ev.Type).State = EntityState.Unchanged;
            await context.Events.AddAsync(ev);
            await context.SaveChangesAsync();

            return ev.id;
        }
        [HttpPost("AddReceiving")]
        public async Task<ActionResult<int>> AddReceiving(ReceiveObj receiveObj)
        {
            Receiving receiving = receiveObj.receiving;
            foreach (var item in receiving.structures)
            {
                context.Entry(item).State = EntityState.Unchanged;
            }

            foreach (var item in receiving.peoples)
            {
                context.Entry(item).State = EntityState.Unchanged;
            }


            if (receiveObj.receiptAct.Count != 0)
            {
                receiving.receiptAct = receiveObj.receiptAct.ToArray();
            }
            if (receiveObj.receiptAgreement.Count != 0)
            {
                receiving.receiptAgreement = receiveObj.receiptAgreement.ToArray();
            }
            if (receiveObj.receiptAgreement.Count != 0)
            {
                receiving.priceAct = receiveObj.priceAct.ToArray();
            }

            if (receiving.id == 0)
            { 
                UnifPassport unifPassport = await context.UnifPassports.FindAsync(receiveObj.unifId);
                receiving.id = 0;

                context.Entry(receiving.Currency).State = EntityState.Unchanged;
                context.Entry(receiving.Status).State = EntityState.Unchanged;
                context.Entry(receiving.Owner).State = EntityState.Unchanged;
                context.Entry(receiving.Provider).State = EntityState.Unchanged;
                context.Entry(receiving.ReceiveWay).State = EntityState.Unchanged;
                context.Entry(receiving.Currency).State = EntityState.Unchanged;
                context.Entry(receiving.Producer).State = EntityState.Unchanged;
                context.Entry(receiving.Purpose).State = EntityState.Unchanged;
                context.Entry(receiving.Recipient).State = EntityState.Unchanged;

                unifPassport.Receiving = receiving;

                await context.Receivings.AddAsync(receiving);

            }
            else
            {
                Receiving existedRec = await context.Receivings
                    .Include(x=>x.structures)
                    .Include(x=>x.peoples)
                    .FirstOrDefaultAsync(x => x.id == receiving.id);

                existedRec.structures.Clear();
                existedRec.peoples.Clear();
                //receiving.events.Clear();

                await context.SaveChangesAsync();

                context.Entry(existedRec).State = EntityState.Detached;
                context.Receivings.Update(receiving);
            }
            await context.SaveChangesAsync();

            return Ok();
        }
        [HttpGet("GetReceiving")]
        public async Task<ActionResult<Receiving>> GetReceiving(int id)
        {
            UnifPassport unif = await context.UnifPassports
                .Include(x => x.Receiving)
                .Include(x => x.Receiving.structures)
                .Include(x => x.Receiving.peoples)
                .Include(x => x.Receiving.Status)
                .Include(x => x.Receiving.Owner)
                .Include(x => x.Receiving.Provider)
                .Include(x => x.Receiving.ReceiveWay)
                .Include(x => x.Receiving.Purpose)
                .Include(x => x.Receiving.Currency)
                .Include(x => x.Receiving.Producer)
                .Include(x => x.Receiving.Recipient)
                .FirstAsync(x=>x.Id == id);

            return unif.Receiving;
        }
    }
}
