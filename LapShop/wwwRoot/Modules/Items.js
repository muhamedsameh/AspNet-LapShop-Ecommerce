

var ClsItems = {
    GetAll: function () {
        Helper.AjaxCallGet("https://localhost:7079/api/items", {}, "json",
            function (data) {
                var htmlAllItems = "";

                for (var i = 0; i < data.data.length; i++) {
                    var htmlItem = ClsItems.DrawItem(data.data[i]);
                    htmlAllItems += htmlItem;
                }

                // change inner html of itemArea elemnt
                $("#ItemsArea").html(htmlAllItems);

            }, function () { console.log("failed"); })
    },
    DrawItem: function (item) {

        var rawData = `
        <div class="col-xl-3 col-6 col-grid-box">
            <div class="product-box">
                <div class="img-wrapper">
                    <div class="front">
                        <a href="/ItemDetails/${item.itemId}"> <img src="/Uploads/Items/${item.imageName}" class="img-fluid blur-up lazyload bg-img" alt=""></a>
                    </div>
                    <div class="back">
                        <a href="/ItemDetails/${item.itemId}"> <img src="/Uploads/Items/${item.imageName}" class="img-fluid blur-up lazyload bg-img" alt=""></a>
                    </div>
                    <div class="cart-info cart-wrap">
                        <button data-toggle="modal" data-target="#addtocart" title="Add to cart">
                            <i class="ti-shopping-cart"></i>
                        </button> <a href="javascript:void(0)" title="Add to Wishlist">
                            <i class="ti-heart" aria-hidden="true"></i>
                        </a> <a href="#" data-toggle="modal" data-target="#quick-view" title="Quick View">
                            <i class="ti-search" aria-hidden="true"></i>
                        </a> <a href="compare.html" title="Compare">
                            <i class="ti-reload" aria-hidden="true"></i>
                        </a>
                    </div>
                </div>
                <div class="product-detail">
                    <div>
                        <div class="rating"><i class="fa fa-star"></i> <i class="fa fa-star"></i> <i class="fa fa-star"></i> <i class="fa fa-star"></i> <i class="fa fa-star"></i></div>
                        <a href="ItemDetails/${item.itemId}">
                            <h6>${item.itemName}</h6>
                        </a>
                        <p>
                            Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley
                            of type and scrambled it to make a type specimen book
                        </p>
                        <h4>$${item.salesPrice}</h4>
                    </div>
                </div>
            </div>
        </div>`

        return rawData;
    }
}