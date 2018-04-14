// @flow
import * as React from 'react'

import type { Props } from './index.h'
import isTruth from './super-intelligence'

function TruthDetector({ value }: Props): React.Node {
  return isTruth(value) ? 'Yeah!' : 'Naah!'
}

export default TruthDetector
