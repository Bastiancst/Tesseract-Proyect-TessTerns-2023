using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ferreteria_backend.Data;
using ferreteria_backend.Models;
using ferreteria_backend.Models.DTO;
using ferreteria_backend.Repository.IRepository;
using System.Net;
using System.Security.Authentication;

namespace ferreteria_backend.Controllers
{
    [Route("api/ItemAPI")]
    [ApiController]
    public class ItemAPIController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IItemRepository _dbItem;
        private readonly IMapper _mapper;
        public ItemAPIController(IItemRepository dbItem, IMapper mapper)
        {
			_dbItem = dbItem;
            _mapper = mapper;
            this._response = new();
        }

        // GET ALL
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetItems()
        {
            try
            { 
            IEnumerable<Item> ItemList = await _dbItem.GetAllAsync();
            _response.Result = _mapper.Map<List<ItemDTO>>(ItemList);
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<String>() { ex.ToString() };
            }
            return _response;

        }

        //GET BY ID
        [HttpGet("{id:int}", Name = "GetItem")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetItem(int id)
        { 
            try 
            { 
                if (id==0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var item = await _dbItem.GetAsync(u => u.Id == id);
                if (item == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<ItemDTO>(item);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<String>() { ex.ToString() };
            }
            return _response;
        }

        // POST
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<APIResponse>> CreateItem([FromBody] ItemCreateDTO createDTO)
        {
            try 
            {
                if(await _dbItem.GetAsync(u => u.Id == createDTO.Id) != null)
                {
                    ModelState.AddModelError("CustomError", "Item already Exists!");
                    return BadRequest(ModelState);
                }

                if (createDTO == null)
                {
                    return BadRequest(createDTO);
                }

				Item item = _mapper.Map<Item>(createDTO);

                await _dbItem.CreateAsync(item);
                _response.Result = _mapper.Map<ItemDTO>(item);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetItem", new { id = item.Id },_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<String>() { ex.ToString() };
            }
            return _response;
        }


        // UPDATE
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id:int}", Name = "UpdateItem")]
        public async Task<ActionResult<APIResponse>> UpdateItem(int id, [FromBody] ItemDTO updateDTO)
        {
            try 
            { 
                if (updateDTO == null || id != updateDTO.Id)
                {
                    return BadRequest();
                }

				Item model = _mapper.Map<Item>(updateDTO);
  
                await _dbItem.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<String>() { ex.ToString() };
            }
            return _response;
        }


        // DELETE
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id:int}", Name = "DeleteItem")]
        public async Task<ActionResult<APIResponse>> DeleteItem(int id)
        {
            try 
            { 
                if (id==0)
                {
                    return BadRequest();
                }
                var item = await _dbItem.GetAsync(u => u.Id == id);
                if (id==null)
                {
                    return NotFound();
                }
                await _dbItem.RemoveAsync(item);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                    = new List<String>() { ex.ToString() };
            }
            return _response;

        }


    }
}
