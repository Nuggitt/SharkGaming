
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;
using SharkGaming.Products.Components.ComponentTypes.PowerSupply;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Products.Components;
using SharkGaming.Products.CustomPc;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Products;
using SharkGaming.MockData.MProducts.MComponents.MComponentTypes;
using SharkGaming.MockData.Products.Components;
using SharkGaming.Services.JsonServiceFile;
using SharkGaming.MockData.Products.PreBuilds;
using System.Text.Json.Nodes;

namespace SharkGaming.Services.ProductServiceFile
{
    public class ProductService : IProductService
    {
        #region Lists       
        private List<ProductsClass> _preBuilds;
        private List<CustomPcClass> _customPcs;
        private List<Cases> _cases;
        private List<CaseFan> _caseFans;
        private List<CPUAirCooling> _cPUAirCooling;
        private List<CPUWaterCooling> _cPUWaterCooling;
        private List<CPU> _cPUs;
        private List<GPU> _gPUs;
        private List<Motherboard> _motherboards;
        private List<PowerSupply> _powerSupplies;
        private List<RAM> _rAMs;
        private List<Mdot2> _mdot2s;
        private List<SolidStateDrive> _solidStateDrives;
        #endregion

        #region initialise Lists
        public ProductService()
        {
            
            //_preBuilds = MockPreBuilds.GetMockPreBuilds();
            //_customPcs = MockCustomPC.GetMockCustomPcs();
            _cases = MockCaseS.GetMockCases();            
            _caseFans = MockCaseFan.GetMockCaseFans();
            _cPUAirCooling = MockCPUAirCooling.GetMockCPUAirCoolings();
            _cPUWaterCooling = MockCPUWaterCooling.GetMockCPUWaterCooling();
            _cPUs = MockCPU.GetMockCPUs();
            _gPUs = MockGPU.GetMockGPUs();
            _motherboards = MockMotherboard.GetMockMotherboards();
            _powerSupplies = MockPowerSupply.GetMockPowerSupplies();            
            _rAMs = MockRam.GetMockRam();
            _mdot2s = MockMdot.GetMockMdot2s();
            _solidStateDrives = MockSolidStateDrive.GetMockSoildSateDrives();
        }
        #endregion

        #region Get methods       
        public List<ProductsClass> GetPreBuilds()
        {
            return _preBuilds;
        }
        public List<CustomPcClass> GetCustomPc()
        {
            return _customPcs;
        }
        public List<Cases> GetCases()
        {
            return _cases;
        }      
        public List<CaseFan> GetCaseFans()
        {
            return _caseFans;
        }       
        public List<CPUAirCooling> GetCPUAirCooling()
        {
            return _cPUAirCooling;
        }
        public List<CPUWaterCooling> GetCPUWaterCooling()
        {
            return _cPUWaterCooling;
        }
        public List<CPU> GetCPUs()
        {
            return _cPUs;
        }
        public List<GPU> GetGPUs()
        {
            return _gPUs;
        }


        public List<Motherboard> GetMotherboards()
        {
            return _motherboards;
        }
        public List<PowerSupply> GetPowerSupply()
        {
            return _powerSupplies;
        }
        public List<RAM> GetRAM()
        {
            return _rAMs;
        }
        public List<Mdot2> GetMdot2()
        {
            return _mdot2s;
        }
        public List<SolidStateDrive> GetSolidStateDrives()
        {
            return _solidStateDrives;
        }
        #endregion

        #region Add to list methods
        public void AddPreBuild(ProductsClass preBuilds)
        {
            _preBuilds.Add(preBuilds);
            JsonService.SaveJsonPreBuilds(_preBuilds);  
        }
        public void AddCustomPc(CustomPcClass customPc)
        {
            _customPcs.Add(customPc);
            JsonService.SaveJsonCustomPcs(_customPcs);   
        }
        public void AddCase(Cases cas)
        {
            _cases.Add(cas);
            JsonService.SaveJsonCases(_cases);
        }       
        public void AddCaseFan(CaseFan caseFan)
        {
            _caseFans.Add(caseFan);
            JsonService.SaveJsonCaseFans(_caseFans);
        }
        public void AddCPUAirCooling(CPUAirCooling air)
        {
            _cPUAirCooling.Add(air);
            JsonService.SaveJsonCPUAirCooling(_cPUAirCooling);
        }
        public void AddCPUWaterCooling(CPUWaterCooling water)
        {
            _cPUWaterCooling.Add(water);
            JsonService.SaveJsonCPUWaterCooling(_cPUWaterCooling);
        }
        public void AddCPU(CPU cpu)
        {
            _cPUs.Add(cpu);
            JsonService.SaveJsonCPU(_cPUs);
        }
        public void AddGPU(GPU gpu)
        {
            _gPUs.Add(gpu);
            JsonService.SaveJsonGPU(_gPUs);
        }
        public void AddMotherboard(Motherboard motherboard)
        {
            _motherboards.Add(motherboard);
            JsonService.SaveJsonMotherboards(_motherboards);
        }
        public void AddPowerSupply(PowerSupply psu)
        {
            _powerSupplies.Add(psu);
            JsonService.SaveJsonPowerSupply(_powerSupplies);
        }
        public void AddRAM(RAM ram)
        {
            _rAMs.Add(ram);           
            JsonService.SaveJsonRAM(_rAMs);
        }
        public void AddMdot2(Mdot2 mdot2)
        {
            _mdot2s.Add(mdot2);
            JsonService.SaveJsonMdot2(_mdot2s);
        }
        public void AddSolidStateDrive(SolidStateDrive ssd)
        {
            _solidStateDrives.Add(ssd);
            JsonService.SaveJsonSSD(_solidStateDrives);
        }

        #endregion

        #region json
        private JsonService JsonService { get; set; }

        public ProductService(JsonService jsonService)
        {
            JsonService = jsonService;
            //_preBuilds = MockPreBuilds.GetMockPreBuilds().ToList();
            //_customPcs = MockCustomPC.GetMockCustomPcs().ToList();
            _cases = MockCaseS.GetMockCases().ToList();
            _caseFans = MockCaseFan.GetMockCaseFans().ToList();
            _cPUAirCooling = MockCPUAirCooling.GetMockCPUAirCoolings().ToList();
            _cPUWaterCooling = MockCPUWaterCooling.GetMockCPUWaterCooling().ToList();
            _cPUs = MockCPU.GetMockCPUs().ToList();
            _gPUs = MockGPU.GetMockGPUs().ToList();
            _motherboards = MockMotherboard.GetMockMotherboards().ToList();
            _powerSupplies = MockPowerSupply.GetMockPowerSupplies().ToList();
            _rAMs = MockRam.GetMockRam().ToList();
            _mdot2s = MockMdot.GetMockMdot2s().ToList();
            _solidStateDrives = MockSolidStateDrive.GetMockSoildSateDrives().ToList();


            //_cases = JsonService.GetJsonCases().ToList();
            //_caseFans = JsonService.GetJsonCaseFans().ToList();
            //_cPUAirCooling = JsonService.GetJsonCPUAirCooling().ToList();
            //_cPUWaterCooling = JsonService.GetJsonCPUWaterrCooling().ToList();
            //_cPUs = JsonService.GetJsonCPU().ToList();
            //_gPUs = JsonService.GetJsonGPU().ToList();
            //_motherboards = JsonService.GetJsonMotherboards().ToList();
            //_powerSupplies = JsonService.GetJsonPowerSupply().ToList();
            //_rAMs = JsonService.GetJsonRAM().ToList();
            //_mdot2s = JsonService.GetJsonMdot2().ToList();
            //_solidStateDrives = JsonService.GetJsonSSD().ToList();
        }
        #endregion

        #region Name Search
        public IEnumerable<ProductsClass> ProductNameSearch(string str)
        {
            List<ProductsClass> nameSearch = new List<ProductsClass>();
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    foreach (ProductsClass item in _preBuilds)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _cases)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _caseFans)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _cPUAirCooling)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _cPUWaterCooling)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _cPUs)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _gPUs)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _motherboards)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _powerSupplies)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _rAMs)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _mdot2s)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                    foreach (ProductsClass item in _solidStateDrives)
                    {
                        if (item.Name.ToLower().Contains(str.ToLower()))
                        {
                            nameSearch.Add(item);
                        }
                    }
                }
                return nameSearch;
            }
        }
        #endregion

        #region update methods
        public void UpdateProduct(ProductsClass item)
        {
            if (item != null)
            {
                foreach (ProductsClass i in _preBuilds)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonPreBuilds(_preBuilds);
                }              
                
                foreach (ProductsClass i in _cases)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonCases(_cases);
                }

                foreach (ProductsClass i in _cPUAirCooling)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonCPUAirCooling(_cPUAirCooling);
                }

                foreach (ProductsClass i in _cPUWaterCooling)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonCPUWaterCooling(_cPUWaterCooling);
                }
                
                foreach (ProductsClass i in _cPUs)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonCPU(_cPUs);
                }

                foreach (ProductsClass i in _gPUs)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonGPU(_gPUs);
                }

                foreach (ProductsClass i in _motherboards)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonMotherboards(_motherboards);
                }
                
                foreach (ProductsClass i in _powerSupplies)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonPowerSupply(_powerSupplies);
                }

                foreach (ProductsClass i in _rAMs)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonRAM(_rAMs);
                }

                foreach (ProductsClass i in _mdot2s)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonMdot2(_mdot2s);
                }

                foreach (ProductsClass i in _solidStateDrives)
                {
                    if (i.Id == item.Id)
                    {
                        i.Price = item.Price;
                        i.Name = item.Name;
                    }
                    JsonService.SaveJsonSSD(_solidStateDrives);
                }

            }
        }
        public void UpdateRAM(RAM ram)
        {
            if (ram != null)
            {
                foreach (RAM i in _rAMs)
                {
                    if (i.Id == ram.Id)
                    {
                        i.Name = ram.Name;
                        i.Price = ram.Price;
                    }
                }
                JsonService.SaveJsonRAM(_rAMs);
            }
        }

        #endregion

        #region price filter 
        public IEnumerable<ProductsClass> PriceFilter(double maxPrice, double minPrice = 0)
        {
            List<ProductsClass> filterList = new List<ProductsClass>();
            foreach (ProductsClass item in _preBuilds)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }
            
            foreach (ProductsClass item in _cases)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _caseFans)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _cPUAirCooling)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _cPUWaterCooling)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _cPUs)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _gPUs)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _motherboards)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _powerSupplies)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _rAMs)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _mdot2s)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            foreach (ProductsClass item in _solidStateDrives)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }

            return filterList;
        }
        #endregion

        #region Get Product via ID
        public ProductsClass GetProduct(int id)
        {
            if (id != null)
            {
                foreach (ProductsClass i in _preBuilds)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _cases)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _caseFans)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _cPUAirCooling)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _cPUWaterCooling)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _cPUs)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _gPUs)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _motherboards)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _powerSupplies)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _rAMs)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _mdot2s)
                    if (i.Id == id)
                    {
                        return i;
                    }
                foreach (ProductsClass i in _solidStateDrives)
                    if (i.Id == id)
                    {
                        return i;
                    }
            }
            return null;
        }
        #endregion

        public RAM GetRAMs(int id)
        {
            if (id != null)
            {
                foreach (RAM i in _rAMs)
                {
                    if (i.Id == id)
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        #region Delete Product
        public ProductsClass DeleteProduct(int? itemId)
        {
            ProductsClass deletedProduct = null;

            #region Delete Pre Build
            ProductsClass preBuildToBeDeleted = null;
            foreach (ProductsClass item in _preBuilds)
            {
                if (item.Id == itemId)
                {
                    preBuildToBeDeleted = item;
                    break;
                }
            }
            if (preBuildToBeDeleted != null)
            {
                _preBuilds.Remove(preBuildToBeDeleted);
                JsonService.SaveJsonPreBuilds(_preBuilds);
                deletedProduct = preBuildToBeDeleted;
            }
            #endregion

            // custom pc

            #region Delete Case
            Cases caseToBeDeleted = null;
            foreach (Cases item in _cases)
            {
                if (item.Id == itemId)
                {
                    caseToBeDeleted = item;
                    break;
                }
            }
            if (caseToBeDeleted != null)
            {
                _cases.Remove(caseToBeDeleted);
                JsonService.SaveJsonCases(_cases);
                deletedProduct = caseToBeDeleted;
            }
            #endregion

            #region Delete CaseFan
            CaseFan caseFanToBeDeleted = null;
            foreach (CaseFan item in _caseFans)
            {
                if (item.Id == itemId)
                {
                    caseFanToBeDeleted = item;
                    break;
                }
            }
            if (caseFanToBeDeleted != null)
            {
                _caseFans.Remove(caseFanToBeDeleted);
                JsonService.SaveJsonCaseFans(_caseFans);
                deletedProduct = caseFanToBeDeleted;
            }
            #endregion

            #region Delete CPU Air Cooling
            CPUAirCooling cPUAirToBeDeleted = null;
            foreach (CPUAirCooling item in _cPUAirCooling)
            {
                if (item.Id == itemId)
                {
                    cPUAirToBeDeleted = item;
                    break;
                }
            }
            if (cPUAirToBeDeleted != null)
            {
                _cPUAirCooling.Remove(cPUAirToBeDeleted);
                JsonService.SaveJsonCPUAirCooling(_cPUAirCooling);
                deletedProduct = cPUAirToBeDeleted;
            }
            #endregion

            #region Delete CPU Water Cooling
            CPUWaterCooling cPUWaterToBeDeleted = null;
            foreach (CPUWaterCooling item in _cPUWaterCooling)
            {
                if (item.Id == itemId)
                {
                    cPUWaterToBeDeleted = item;
                    break;
                }
            }
            if (cPUWaterToBeDeleted != null)
            {
                _cPUWaterCooling.Remove(cPUWaterToBeDeleted);
                JsonService.SaveJsonCPUWaterCooling(_cPUWaterCooling);
                deletedProduct = cPUWaterToBeDeleted;
            }
            #endregion

            #region Delete CPU 
            CPU cPUToBeDeleted = null;
            foreach (CPU item in _cPUs)
            {
                if (item.Id == itemId)
                {
                    cPUToBeDeleted = item;
                    break;
                }
            }
            if (cPUToBeDeleted != null)
            {
                _cPUs.Remove(cPUToBeDeleted);
                JsonService.SaveJsonCPU(_cPUs);
                deletedProduct = cPUToBeDeleted;
            }
            #endregion

            #region Delete GPU 
            GPU gPUToBeDeleted = null;
            foreach (GPU item in _gPUs)
            {
                if (item.Id == itemId)
                {
                    gPUToBeDeleted = item;
                    break;
                }
            }
            if (gPUToBeDeleted != null)
            {
                _gPUs.Remove(gPUToBeDeleted);
                JsonService.SaveJsonGPU(_gPUs);
                deletedProduct = gPUToBeDeleted;
            }
            #endregion

            #region Delete Motherboard 
            Motherboard motherboardToBeDeleted = null;
            foreach (Motherboard item in _motherboards)
            {
                if (item.Id == itemId)
                {
                    motherboardToBeDeleted = item;
                    break;
                }
            }
            if (motherboardToBeDeleted != null)
            {
                _motherboards.Remove(motherboardToBeDeleted);
                JsonService.SaveJsonMotherboards(_motherboards);
                deletedProduct = motherboardToBeDeleted;
            }
            #endregion

            #region Delete PSU 
            PowerSupply powerSuppliesToBeDeleted = null;
            foreach (PowerSupply item in _powerSupplies)
            {
                if (item.Id == itemId)
                {
                    powerSuppliesToBeDeleted = item;
                    break;
                }
            }
            if (powerSuppliesToBeDeleted != null)
            {
                _powerSupplies.Remove(powerSuppliesToBeDeleted);
                JsonService.SaveJsonPowerSupply(_powerSupplies);
                deletedProduct = powerSuppliesToBeDeleted;
            }
            #endregion
          
            #region Delete RAM
            RAM ramToBeDeleted = null;
            foreach (RAM item in _rAMs)
            {
                if (item.Id == itemId)
                {
                    ramToBeDeleted = item;
                    break;
                }
            }
            if (ramToBeDeleted != null)
            {
                _rAMs.Remove(ramToBeDeleted);
                JsonService.SaveJsonRAM(_rAMs);
                deletedProduct = ramToBeDeleted;
            }
            #endregion

            #region Delete M.2
            Mdot2 mdot2ToBeDeleted = null;
            foreach (Mdot2 item in _mdot2s)
            {
                if (item.Id == itemId)
                {
                    mdot2ToBeDeleted = item;
                    break;
                }
            }
            if (mdot2ToBeDeleted != null)
            {
                _mdot2s.Remove(mdot2ToBeDeleted);
                JsonService.SaveJsonMdot2(_mdot2s);
                deletedProduct = mdot2ToBeDeleted;
            }
            #endregion

            #region Delete SSD
            SolidStateDrive SSDToBeDeleted = null;
            foreach (SolidStateDrive item in _solidStateDrives)
            {
                if (item.Id == itemId)
                {
                    SSDToBeDeleted = item;
                    break;
                }
            }
            if (SSDToBeDeleted != null)
            {
                _solidStateDrives.Remove(SSDToBeDeleted);
                JsonService.SaveJsonSSD(_solidStateDrives);
                deletedProduct = SSDToBeDeleted;
            }
            #endregion
            
            return deletedProduct;
        }
        #endregion

        #region Calculation methods

        public double preBuildsCalculation(PreBuildsClass preBuildsClass)
        {
            double price = 0;
            //foreach (PreBuildsClass item in preBuildsClass)
            //{
            //    price += item.Price;
            //}
            //if (preBuildsClass.Discount == true)
            //{
            //    price += -1000;
            //}
            return price;
        }

        #endregion
    }
}
