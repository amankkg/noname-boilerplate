// @flow
import * as React from "react";

import type { Props, State } from "./index.h";

class TextInput extends React.Component<Props, State> {
  static defaultProps = {
    title: "some description"
  };

  state = {
    value: "42"
  };

  handleChange = (e: SyntheticEvent<HTMLInputElement>) => {
    this.setState({ value: e.currentTarget.value });
  };

  render() {
    return (
      <label htmlFor="someId">
        {this.props.title}
        <input
          id="someId"
          value={this.state.value}
          onChange={this.handleChange}
          title={this.props.title}
        />
      </label>
    );
  }
}

export default TextInput;
