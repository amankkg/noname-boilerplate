// @flow
import "babel-polyfill";
import * as React from "react";
import { render } from "react-dom";

import type { AmbiguousText } from "./index.js.flow";

type Props = {
  title: AmbiguousText
};
type State = {
  value: AmbiguousText
};

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
      <input
        value={this.state.value}
        onChange={this.handleChange}
        title={this.props.title}
      />
    );
  }
}

const rootElement = document.getElementById("root");
if (rootElement != null) {
  render(<TextInput />, rootElement);
}
