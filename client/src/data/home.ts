import { createQuery } from '@/data/index';
const storage = sessionStorage;

export const useProjectsQuery = () => {
  const { data: projects, isLoading } = createQuery(['home-projects'], () => loadProjects())

  return { projects, isLoading }
}

export const useGrantsQuery = () => {
  const { data: grants, isLoading } = createQuery(['home-grants'], () => loadGrants())

  return { grants, isLoading }
}

async function loadGrants() {
  const grants = await import('./grants.json')
  return <Grant[]>grants.default
}

export async function loadProjects(): Promise<Project[]> {
  const key = 'projects-v1';
  
  let data = storage.getItem(key);
  if (data) {
    return JSON.parse(data);
  }
  
  const projectsModule = await import('./projects.json');
  const projects = <Project[]>projectsModule.default;


  storage.setItem(key, JSON.stringify(projects));
  return projects;
}

export interface Project {
  name: string
  slug: string
  city: string
  budgetType: BudgetType
  budgetAmountFrom: number
  budgetAmountTo?: number
  ngoName: string
  tags: string[]
}

export interface Grant {
  name: string
  slug: string
  city: string
  budgetFrom: number
  budgetTo: number
  companyName: string
  tags: string[]
}

export enum BudgetType {
  Money = 'Money',
  People = 'People'
}
