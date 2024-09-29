import 'vuetify/styles'
import './assets/main.scss'

import { createApp } from 'vue'
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'
import { VueQueryPlugin } from '@tanstack/vue-query'
import { lightTheme } from '@/plugins/themes'

import App from './App.vue'
import router from './router'
import { createLocale } from '@/locale'

const vuetify = createVuetify({
  components,
  directives,
  theme: {
    themes: {
      lightTheme,
    },
    defaultTheme: 'lightTheme'
  }
})
const locale = await createLocale()

const app = createApp(App)

app.use(router)
app.use(vuetify)
app.use(VueQueryPlugin)
app.use(locale)

app.mount('#app')
