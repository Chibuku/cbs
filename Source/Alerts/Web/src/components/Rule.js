import React from 'react';

class Rule extends React.Component {
  render() {
    return (
        <li>{this.props.value}</li>
    );
  }
}

export default Rule;