﻿using Com.Danliris.Service.Packing.Inventory.Data.Models.DyeingPrintingAreaMovement;
using Com.Danliris.Service.Packing.Inventory.Infrastructure;
using Com.Danliris.Service.Packing.Inventory.Infrastructure.Repositories.DyeingPrintingAreaMovement;
using Com.Danliris.Service.Packing.Inventory.Test.DataUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Com.Danliris.Service.Packing.Inventory.Test.Repositories
{
    public class DyeingPrintingAreaInputProductionOrderRepositoryWithBalanceRemainsCtorTest
        : BaseRepositoryTest<PackingInventoryDbContext, DyeingPrintingAreaInputProductionOrderRepository, DyeingPrintingAreaInputProductionOrderModel, DyeingPrintingAreaInputProductionOrderWithBalanceRemainsDataUtil>
    {
        private const string ENTITY = "DyeingPrintingAreaOutputProductionOrder";
        public DyeingPrintingAreaInputProductionOrderRepositoryWithBalanceRemainsCtorTest() : base(ENTITY)
        {
        }

        [Fact]
        public async Task Should_Success_GetDbSet()
        {
            string testName = GetCurrentMethod();
            var dbContext = DbContext(testName);

            var repo = new DyeingPrintingAreaInputProductionOrderRepository(dbContext, GetServiceProviderMock(dbContext).Object);
            var data = await DataUtil(repo, dbContext).GetTestData();
            var result = repo.GetDbSet();

            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task Should_Success_ReadAllIgnoreQueryFilter()
        {
            string testName = GetCurrentMethod();
            var dbContext = DbContext(testName);

            var repo = new DyeingPrintingAreaInputProductionOrderRepository(dbContext, GetServiceProviderMock(dbContext).Object);
            var data = await DataUtil(repo, dbContext).GetTestData();
            var result = repo.ReadAllIgnoreQueryFilter();

            Assert.NotEmpty(result);
        }
        [Fact]
        public async Task Should_Success_SetBalanceRemains()
        {
            string testName = GetCurrentMethod();
            var dbContext = DbContext(testName);

            var repo = new DyeingPrintingAreaInputProductionOrderRepository(dbContext, GetServiceProviderMock(dbContext).Object);
            var data = await DataUtil(repo, dbContext).GetTestData();
            var result = repo.ReadAllIgnoreQueryFilter();
            foreach (var item in result.ToList())
            {
                item.SetBalanceRemains(10, "test", "test");
            }

            Assert.NotEmpty(result);
        }
    }
}
