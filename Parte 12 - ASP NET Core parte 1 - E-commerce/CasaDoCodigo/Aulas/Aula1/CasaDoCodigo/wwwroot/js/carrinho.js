function clickIncremento(btn) {
    var linhaDoItem = $(btn).parents('[item-id]');
    var itemId = $(linhaDoItem).attr('item-id');
    var novaQtde = $(linhaDoItem).find('input').val();

    var data = {
        Id: itemId,
        Quantidade: novaQtde,
    }
    $.ajax({
        url: '/pedido/updateQuantidade',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(data)
    });

    debugger;
}