// yes, this file is a frontend side authentication with no logic at all :)

const storageKey = 'social-bridge-user'
const storageGuidKey = 'social-bridge-guid-user'
const firmaGuid = '5cf40a5c-d78b-4c7c-9ce9-8238656cc55a'
const fundacjaGuid = 'd57a8729-dadb-4596-98b1-069338363261'

export const userChangedEvent = 'user-changed-event'
export type UserType = 'Firma' | 'Fundacja'

export function setUser(name: UserType) {
  localStorage.setItem(storageKey, name)
  if(name == 'Firma'){
    localStorage.setItem(storageGuidKey, firmaGuid);
  }else{
    localStorage.setItem(storageGuidKey, fundacjaGuid)
  }
  window.dispatchEvent(new Event(userChangedEvent))
}

export function getUser() {
  return localStorage.getItem(storageKey) ?? ''
}

export function getGuid() {
  return localStorage.getItem(storageGuidKey) ?? ''
}

export function logout() {
  localStorage.removeItem(storageKey)
  localStorage.removeItem(storageGuidKey)
  window.dispatchEvent(new Event(userChangedEvent))
}
