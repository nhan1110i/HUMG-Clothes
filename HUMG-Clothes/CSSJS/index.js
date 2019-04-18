$(document).ready(function () {
    $('#lbtnAddtoCart').click(function () {
        alert("Đã thêm vào giỏ hàng");
    });
    $('#dropdown-1').click(function () {
        window.location.href = "?page=FemaleClothes";
    });
    $('#dropdown-2').click(function () {
        window.location.href = "?page=MaleClothes";
    });
    $('#dropdown-1').mouseover(function() {
        $('#dropdown-menu-1').show()
    });
    $('#dropdown-1').mouseout(function() {
        t = setTimeout(function() {
            $('#dropdown-menu-1').hide()
        }, 100);

        $('#dropdown-menu-1').on('mouseenter', function() {
            $('#dropdown-menu-1').show()
            clearTimeout(t);
        }).on('mouseleave', function() {
           $('#dropdown-menu-1').hide()
        });
    });
    $('#dropdown-2').mouseover(function() {
        $('#dropdown-menu-2').show()
    });

    $('#dropdown-2').mouseout(function() {
        t = setTimeout(function() {
            $('#dropdown-menu-2').hide()
        }, 100);

        $('#dropdown-menu-2').on('mouseenter', function() {
            $('#dropdown-menu-2').show()
            clearTimeout(t)
        }).on('mouseleave', function() {
            $('#dropdown-menu-2').hide()
        });
    });
});
function AddtoCart() {
    alert("Đã thêm vào giỏ");
};