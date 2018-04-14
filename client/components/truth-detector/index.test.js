import React from 'react'

import Component from './index'

test('should just pass', () => {
  expect(<Component value={0} />).toMatchSnapshot()
})

test('should return `Aye!` if value is 42', () => {
  expect(<Component value={42} />).toMatchSnapshot()
})

test('should return `Naah!` if value is not 42', () => {
  expect(<Component value={41} />).toMatchSnapshot()
})
