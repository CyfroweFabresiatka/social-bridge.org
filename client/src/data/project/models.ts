export interface Project {
    budgetAmountFrom: number;
    budgetAmountTo: number;
    budgetType: number;
    createdAt: string;
    description: string;
    id: string;
    locations: string[];
    name: string;
    ngo: Ngo;
    plannedEndDate: string;
    plannedStartDate: string;
    slug: string;
    status: number;
    tags: string[];
}

export interface Ngo {
    id: string;
    name: string;
}