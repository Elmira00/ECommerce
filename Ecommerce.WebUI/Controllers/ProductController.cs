using Ecommerce.Business.Abstract;
using Ecommerce.Entities.Models;
using Ecommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: ProductController
        public async Task<ActionResult> Index(int page = 1, int category = 0)
        {
            int pageSize = 10;
            var items = await _productService.GetAllByCategoryAsync(category);

            var model = new ProductListViewModel
            {
                Products = items.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                CurrentCategory = category,
                PageCount = (int)Math.Ceiling(items.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentPage = page
            };
            return View(model);
        }
        static void BubbleSort(List<Product> arr, int sort)
        {
            int n = arr.Count;
            bool swapped;
            if (sort == 0)
            {

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        // Compare first letters of the words
                        if (arr[j].ProductName[0] > arr[j + 1].ProductName[0])
                        {
                            // Swap arr[j] and arr[j + 1]
                            Product temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;

                            swapped = true;
                        }
                    }

                    // If no elements were swapped in the inner loop, the array is already sorted
                    if (!swapped)
                        break;
                }
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        // Compare first letters of the words
                        if (arr[j].ProductName[0] < arr[j + 1].ProductName[0])
                        {
                            // Swap arr[j] and arr[j + 1]
                            Product temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;

                            swapped = true;
                        }
                    }

                    // If no elements were swapped in the inner loop, the array is already sorted
                    if (!swapped)
                        break;
                }
            }
        }
        public async Task<ActionResult> Sort(int page, int category, int sorting, int count, int size)
        {
            int pageSize = 10;
            var items = await _productService.GetAllByCategoryAsync(category);
            var myProducts = items.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            BubbleSort(myProducts, sorting);
            var model = new SortProductsListViewModel
            {
                Products = myProducts,
                Page = page,
                Category = category,
                Sorting = sorting,
                Size = size,
                Count = count
            };
            return View(model);
        }
        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}