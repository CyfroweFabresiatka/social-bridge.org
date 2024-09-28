import { createI18n, useI18n } from 'vue-i18n';
import { ref } from 'vue';

const DefaultLang = 'pl';
const StorageKey = 'social-bridge.langCode.v1';

export async function createLocale() {
  const langCode = localStorage.getItem(StorageKey);
  return createI18n({
    legacy: false,
    locale: langCode ?? DefaultLang,
    messages: {
      'pl': await import('./translations/pl.json'),
    },
  });
}

export function useLocale() {
  const { t } = useI18n();
  const current = ref(localStorage.getItem(StorageKey) ?? DefaultLang);

  return {
    t,
    current,
  }
}
