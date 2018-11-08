module.exports = {
  collectCoverage: true,
  collectCoverageFrom: ['client/**/*.{js,jsx}', '!client/**/*.{h,test,spec}.{js,jsx}'],
  coverageReporters: ['text'],
  coveragePathIgnorePatterns: ['<rootDir>/node_modules/', '<rootDir>/build/'],
  setupFiles: ['<rootDir>/tools/enzyme-shim.js'],
  testEnvironment: 'node',
  testPathIgnorePatterns: ['<rootDir>[/\\\\](build|docs|node_modules|src)[/\\\\]'],
  testRegex: '/client/.*(\\.|/)(test|spec)\\.jsx?$',
}
