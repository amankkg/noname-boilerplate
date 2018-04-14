// @flow
import * as React from 'react'

import type { Props } from './index.h'

function TruthDetector({ value }: Props): React.Node {
  return value === 42 ? 'Aye!' : 'Naah!'
}

export default TruthDetector
