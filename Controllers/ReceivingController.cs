using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Museum.Data;
using Museum.Data.ObjsForReceiving;
using Museum.Models.Tabs.Receiving;

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
        public async Task<ActionResult<int>> AddStructure(Structure structure)
        {
            await context.Structures.AddAsync(structure);
            await context.SaveChangesAsync();
            return structure.id;
        }
        [HttpPost("AddPeople")]
        public async Task<ActionResult<int>> AddPeople(People people)
        {
            await context.Peoples.AddAsync(people);
            await context.SaveChangesAsync();
            return people.id;
        }
        [HttpPost("AddOwner")]
        public async Task<ActionResult<int>> AddOwner(Owner owner)
        {
            await context.Owners.AddAsync(owner);
            await context.SaveChangesAsync();
            return owner.id;
        }
        [HttpPost("AddProvider")]
        public async Task<ActionResult<int>> AddProvider(Provider provider)
        {
            await context.Providers.AddAsync(provider);
            await context.SaveChangesAsync();
            return provider.id;
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
            receiving.receiptAct = receiveObj.receiptAct.ToArray();
            receiving.receiptAgreement = receiveObj.receiptAgreement.ToArray();
            receiving.priceAct = receiveObj.priceAct.ToArray();

            await context.Receivings.AddAsync(receiving);
            await context.SaveChangesAsync();

            return receiving.id;
        }
    }
}
