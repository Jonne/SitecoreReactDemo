var Cart = React.createClass({
    propTypes : {
        Cart : React.PropTypes.object
    },
    getInitialState: function (){
        return {
            data : this.props.Cart
        };
    },
    handleRemove: function (productId){
        $.post('api/cart/remove',{productId: productId}).done(this.refresh);
    },
    refresh: function (){
        $.get('api/cart').done(data =>{
            this.setState({ data : data });
        });
    },
    render: function () {
        return (
            <ul>
					<li className="row list-inline columnCaptions">
						<span>QTY</span>
						<span>ITEM</span>
						<span>Price</span>
					</li>

                    {
                        this.state.data.LineItems.map(item => {
                            return (<CartLine LineItem={item} onRemove={this.handleRemove} />);
                        })
                    }

					<li className="row totals">
						<span className="itemName">Total:</span>
						<span className="price">${this.state.data.Subtotal}</span>
						<span className="order"> <a className="text-center">ORDER</a></span>
					</li>
				</ul>
      );
    }
});

