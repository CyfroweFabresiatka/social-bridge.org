import 'vuetify/styles';
import './assets/main.scss';

import { createApp } from 'vue'
import { createVuetify } from 'vuetify';
import * as components from 'vuetify/components';
import * as directives from 'vuetify/directives';
import { VueQueryPlugin } from '@tanstack/vue-query';

import App from './App.vue';
import { createAppRouter } from './router';
import { createLocale } from '@/locale'

const vuetify = createVuetify({
    components,
    directives,
});
const locale = await createLocale()

const router = createAppRouter();

const app = createApp(App)

app.use(router)
app.use(vuetify);
app.use(VueQueryPlugin);
app.use(locale);

app.mount('#app')
