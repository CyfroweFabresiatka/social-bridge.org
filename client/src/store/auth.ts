const storageKey = 'social-bridge-user'

export const userChangedEvent = 'user-changed-event'
export type UserType = 'Firma' | 'Fundacja'

export function setUser(name: UserType) {
  localStorage.setItem(storageKey, name)
  window.dispatchEvent(new Event(userChangedEvent))
}

export function getUser() {
  return localStorage.getItem(storageKey) ?? ''
}

export function logout() {
  localStorage.removeItem(storageKey)
  window.dispatchEvent(new Event(userChangedEvent))
}
