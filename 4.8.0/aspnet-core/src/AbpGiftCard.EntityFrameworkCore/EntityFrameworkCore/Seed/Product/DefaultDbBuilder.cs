using AbpGiftCard.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpGiftCard.EntityFrameworkCore.Seed.Product
{
    public class DefaultDbBuilder
    {
        private readonly AbpGiftCardDbContext _context;
        public DefaultDbBuilder(AbpGiftCardDbContext context)
        {
            _context = context;
        }
        public void Create()
        {
            CreateDefaultInitData();
        }

        public void CreateDefaultInitData()
        {
            #region 增加商品数据

            var products = new[] {
                new AbpGiftCard.Entitys.ProductInformation{ ProductName="铅笔",ProductStatus=Entitys.ProductEnum.Yes,ProductId=11111,SalePrice=1.2,SaledStock=20}
                ,new AbpGiftCard.Entitys.ProductInformation{ ProductName="电饭锅",ProductStatus=Entitys.ProductEnum.Yes,ProductId=1123,SalePrice=22.2,SaledStock=100}
                ,new AbpGiftCard.Entitys.ProductInformation{ ProductName="手机",ProductStatus=Entitys.ProductEnum.No,ProductId=11121,SalePrice=1000,SaledStock=30},
            };

            foreach (var item in products)
            {
                _context.ProductInformations.Add(item);
            }
            _context.SaveChanges();


            #endregion

            #region 初始化商品分类数据

            //规则就是1->100-199 种sku
            var catelogs = new[] {
                new Catelog{ ClassId=1,ClassName="食品",Level=ClassLevel.First },
                new Catelog{ ClassId = 101,ClassName="饼干",Level=ClassLevel.Second},
                new Catelog{ ClassId = 101001,ClassName="旺仔饼干",Level=ClassLevel.Third},
                new Catelog{ ClassId = 101002,ClassName="奥利奥",Level=ClassLevel.Third},

                new Catelog{ ClassId = 102,ClassName="巧克力",Level=ClassLevel.Second},
                new Catelog{ ClassId = 102001,ClassName="德芙",Level=ClassLevel.Third},
                new Catelog{ ClassId = 103,ClassName="面包",Level=ClassLevel.Second},
                new Catelog{ ClassId = 103001,ClassName="土司",Level=ClassLevel.Third},
                new Catelog{ ClassId = 103002,ClassName="切片面包",Level=ClassLevel.Third},

                new Catelog{ ClassId=2,ClassName ="饮料",Level=ClassLevel.First},

            };
            foreach (var item in catelogs)
            {
                _context.Catelogs.Add(item);
            }
            _context.SaveChanges();


            #endregion

            #region 初始化供应商信息

            var suppliers = new[] {
                new Supplier{SupplierId=1111,SupplierName="供应商1",SupplierType=SupplierType.Self,FinanceContactor="小李",FinancePhone="1243213213",FinanceRef=new Finance(){TaxNumber="1213213",TaxTitle="财务",
                 Openbank="中国银行",BankAccount="21321314341"} },
                 new Supplier{SupplierId=1112,SupplierName="供应商2",SupplierType=SupplierType.Self,FinanceContactor="小zhang",FinancePhone="1243213213",FinanceRef=new Finance(){TaxNumber="1213213",TaxTitle="财务",
                 Openbank="中国银行",BankAccount="21321314341"} },
                      new Supplier{SupplierId=1113,SupplierName="供应商3",SupplierType=SupplierType.Self,FinanceContactor="liming",FinancePhone="1243213213",FinanceRef=new Finance(){TaxNumber="1213213",TaxTitle="财务",
                 Openbank="中国银行",BankAccount="21321314341"} },

            };
            foreach (var item in suppliers)
            {
                _context.Suppliers.Add(item);
            }
            _context.SaveChanges();

            #endregion



            #region 初始化劵信息



            #endregion


        }

    }
}
