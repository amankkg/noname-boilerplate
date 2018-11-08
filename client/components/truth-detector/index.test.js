import React from 'react'
import { shallow } from 'enzyme'

import Component from './index'

test('should just pass', () => {
  expect(<Component value={0} />).toMatchSnapshot()
})

test('should return `Yeah!` if value is 17', () => {
  const actual = shallow(<Component value={17} />)

  expect(actual).toMatchSnapshot()
})

test('should return `Naah!` if value is not 17', () => {
  const actual = shallow(<Component value={42} />)

  expect(actual).toMatchSnapshot()
})
