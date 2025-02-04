﻿using System;
using System.Linq;
using System.Threading.Tasks;
using AspnetRunBasics.Models;
using AspnetRunBasics.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspnetRunBasics
{
    public class CartModel : PageModel
    {
        private readonly IBasketService _basketService;

        public CartModel(IBasketService basketService)
        {
            _basketService = basketService;
        }

        public BasketModel Cart { get; set; } = new BasketModel();        

        public async Task<IActionResult> OnGetAsync()
        {
            Cart = await _basketService.GetBasket("coresoft");        

            return Page();
        }

        public async Task<IActionResult> OnPostRemoveToCartAsync(string ProductId)
        {
            //var  basket= await _basketService.GetBasket("coresoft");
            //basket.Items.Remove(basket.Items.Single(p => p.ProductId == ProductId));
            //Cart=await _basketService.UpdateBasket(basket);
            //await _basketService.de
            return RedirectToPage();
        }
    }
}