var CartLine = React.createClass({
    propTypes : {
        LineItem : React.PropTypes.object,
        onRemove : React.PropTypes.func
    },
    render : function (){
        return (
            <li className="row">
                <span className="quantity">1</span>
                <span className="itemName">{this.props.LineItem.Description}</span>
                <span className="popbtn">
                    <a onClick={() => this.props.onRemove(this.props.LineItem.ProductId)}>
                        <span className="glyphicon glyphicon-remove"></span>
                    </a>
                </span>
                <span className="price">${this.props.LineItem.Price}</span>				
            </li>
        );
    }
});