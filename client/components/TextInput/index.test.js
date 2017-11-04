import React from 'react'

import Component from './index'

test('should just pass', () => {
  expect(<Component title="37" />).toMatchSnapshot()
})
