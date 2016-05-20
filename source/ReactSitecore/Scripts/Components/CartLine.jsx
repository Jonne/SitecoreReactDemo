var CartLine = React.createClass({
    propTypes: {
        LineItem: React.PropTypes.object,
        onRemove: React.PropTypes.func
    },
    render: function () {
        return (
            <article>
                <div className="description">{this.props.LineItem.Description}</div>
                <div className="remove">
                    <a href="#" onClick={() => this.props.onRemove(this.props.LineItem.ProductId)}>Remove</a>
                </div>
            </article>
      ); 
    }
});

