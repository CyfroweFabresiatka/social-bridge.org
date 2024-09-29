import type { ThemeDefinition } from 'vuetify'

export const lightTheme: ThemeDefinition = {
  dark: false,
  colors: {
    primary: '#7c3812',
    anchor: '#43a1d1',
    secondary: '#fdc874',
    accent: '#ffbc00',
    error: '#FF5252',
    info: '#2196F3',
    success: '#4CAF50',
    warning: '#f0c560'
  }
}

export const darkTheme: ThemeDefinition = {
  dark: true,
  colors: {
    primary: '#2b6380',
    anchor: '#43a1d1',
    secondary: '#676666',
    accent: '#ffbc00',
    error: '#FF5252',
    info: '#2196F3',
    success: '#4CAF50',
    warning: '#f0c560'
  }
}
