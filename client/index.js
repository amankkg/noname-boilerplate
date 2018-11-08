// @flow
import 'babel-polyfill'
import * as React from 'react'
import { render } from 'react-dom'

import TextInput from 'components/text-input'

const rootElement = document.getElementById('root')
if (rootElement != null) {
  render(<TextInput />, rootElement)
}
