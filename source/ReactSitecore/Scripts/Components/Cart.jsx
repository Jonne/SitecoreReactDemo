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
          <div>
              <div className="products">
                  {
                    this.state.data.LineItems.map(item => {
                        return (<CartLine LineItem={item} onRemove={this.handleRemove } />);
                    })
                  }
              </div>
              <div>
                  <span>Subtotal:</span>
                  <span className="subtotal">{this.state.data.Subtotal}</span>
              </div>
          </div>
      );
    }
});

