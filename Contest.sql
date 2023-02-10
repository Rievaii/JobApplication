select product.name, category.name
from ад
Left join ProductCategory productCat on product.id = productCat.productId
Left join Category Cat on category.id = productCat.categoryId
